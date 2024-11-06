using AutoMapper;
using Landing.DAL.Models;
using Landing.PL.Helpers;
using Landing.PL.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using System.Security.Claims;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;
using VivaStore.PL.Helpers;

namespace Landing.PL.Controllers
{
	public class CartsController : Controller
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;
        
		public CartsController(ApplicationDbContext _context, IMapper mapper)
		{
			context = _context;
			this.mapper = mapper;
		}
		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Cart()
		{
			
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (userId == null)
			{
				return RedirectToAction("Login","Account"); 
			}

		
			var cart = await context.Carts
				.Include(c => c.CartItems)
				.ThenInclude(ci => ci.Product)
				.FirstOrDefaultAsync(c => c.UserId == userId && c.IsActive);

			if (cart == null)
			{
				return View(new CartViewModel {  CartItems = new List<CartItemVM>(), TotalAmount = 0 });
			}

			
			var cartViewModel = mapper.Map<CartViewModel>(cart);

		
			cartViewModel.TotalAmount = cart.CalculateTotal();

			return View(cartViewModel);
		}



		public IActionResult Delete(int id)
		{
			var cartItem = context.CartItems.Find(id);
			if (cartItem == null)
			{
				return NotFound();
			}
			
			context.CartItems.Remove(cartItem);
			context.SaveChanges();
			return RedirectToAction(nameof(Cart));
		}



		[HttpPost]
		[ValidateAntiForgeryToken]
        public async Task<IActionResult> PlaceOrder(OrderViewModel form)
        {
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var cart = await context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId && c.IsActive);

            if (cart == null || !cart.CartItems.Any())
            {
                return BadRequest("Cart is empty.");
            }

            var order = mapper.Map<Order>(form);
            order.UserId = userId;
            order.OrderDate = DateTime.Now;
            order.TotalAmount = cart.CartItems.Sum(ci => ci.Product.Price * ci.Quantity);

           
            if (order.OrderItems == null)
            {
                order.OrderItems = new List<OrderItem>();
            }

            foreach (var item in cart.CartItems)
            {
                order.OrderItems.Add(new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Product.Price
                });
            }

            context.Orders.Add(order);
            context.Carts.Remove(cart);
            await context.SaveChangesAsync();
            var NewOrder = Url.ActionLink("Orders", "Dashboard", protocol: HttpContext.Request.Scheme);
            var email = new Email
            {
                Recivers = "amjadalian14@gmail.com",
                Subject = "New Order!",
                Body = $"Check It Now!!: {NewOrder}"
            };
            EmailSettings.SendEmail(email);

            return RedirectToAction("OrderConfirmation");
        }


		public async Task<IActionResult> OrderConfirmation()
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			
			var orders = await context.Orders
				.Where(o => o.UserId == userId)
				.Include(o => o.OrderItems)
					.ThenInclude(oi => oi.Product)
				.ToListAsync();

			var orderVMs = mapper.Map<List<OrderVM>>(orders);

			return View(orderVMs);
		}

		[HttpPost]

		public async Task<IActionResult> AddToCart(int productId, int quantity)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (userId == null)
			{
				
				return Json(new { redirected = true, loginUrl = Url.Action("Login", "Account") });
			}

			
			var cart = await context.Carts
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.UserId == userId && c.IsActive);

			if (cart == null)
			{
				cart = new Cart { UserId = userId, IsActive = true, CartItems = new List<CartItem>() };
				context.Carts.Add(cart);
			}

			
			var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
			if (cartItem != null)
			{
				cartItem.Quantity += 1;
			}
			else
			{
				var product = await context.Products.FindAsync(productId);
				if (product == null)
				{
					return NotFound();
				}

				cartItem = new CartItem { ProductId = productId, Quantity = quantity, Price = product.Price };
				cart.CartItems.Add(cartItem);
			}

			await context.SaveChangesAsync();

			
			var uniqueItemCount = cart.CartItems.Count;
			return Json(new { redirected = false, success = true, itemCount = uniqueItemCount });
		}

		[HttpGet]
		public async Task<IActionResult> GetUniqueItemCount()
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (userId == null) return Json(new { itemCount = 0 });

			var cart = await context.Carts
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.UserId == userId && c.IsActive);

			var itemCount = cart?.CartItems.Select(ci => ci.ProductId).Distinct().Count() ?? 0;
			return Json(new { itemCount });
		}




	}


}

