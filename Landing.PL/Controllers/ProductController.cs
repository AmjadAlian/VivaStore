using AutoMapper;
using Landing.PL.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace Landing.PL.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public ProductController(ApplicationDbContext _context, IMapper mapper)
		{
			context = _context;
			this.mapper = mapper;
		}
		public async Task<IActionResult> IndexAsync()
		{
			var sliderEntities = await context.SliderHome
		.Where(s => s.IsActive)
		.OrderBy(s => s.Order)
		.ToListAsync();
			var sliderViewModels = mapper.Map<List<SliderHomeVM>>(sliderEntities);


			var productEntities = await context.Products.Where(s => s.IsActive).Include(p => p.Category).ToListAsync();

			var productViewModels = mapper.Map<List<ProductVM>>(productEntities);

			var CategoryEntities = await context.Categories
		  .Where(s => s.IsActive)
		  .OrderBy(s => s.Order)
		  .ToListAsync();

			var CategoryViewModels = mapper.Map<List<CategoryVM>>(CategoryEntities);
			var homeViewModel = new HomePageViewModel
			{
				Sliders = sliderViewModels,
				Products = productViewModels,
				Categories = CategoryViewModels
			};

			return View(homeViewModel);
			
		}
		public async Task<IActionResult> ProductInfo(int id)
		{
			
			var product = await context.Products
				.Include(p => p.Category)
				.FirstOrDefaultAsync(p => p.Id == id);

			if (product == null)
			{
				return NotFound();
			}

		
			var productDetailsVM = mapper.Map<ProductDetailsVM>(product);

			
			return View(productDetailsVM);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
		{
			
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return RedirectToAction("Login","Account");
            }

			
			var cart = await context.Carts
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.UserId == userId && c.IsActive);

			if (cart == null)
			{
				cart = new Cart
				{
					UserId = userId,
					IsActive = true
				};
				context.Carts.Add(cart);
			}

		
			var cartItem = cart.CartItems.FirstOrDefault(item => item.ProductId == productId);

			if (cartItem != null)
			{
			
				cartItem.Quantity += quantity;
			}
			else
			{
				// إضافة منتج جديد إلى السلة
				var product = await context.Products.FindAsync(productId);
				if (product == null) return NotFound();

				cart.CartItems.Add(new CartItem
				{
					ProductId = productId,
					Quantity = quantity,
					Product = product
				});
			}

			
			await context.SaveChangesAsync();

			
			return RedirectToAction("Cart","Carts"); 
		}
		public IActionResult GetProductDetails(int id)
		{
			var product = context.Products.Find(id); // استبدل `_productService` بالطريقة المناسبة لجلب المنتج
			if (product == null)
				return NotFound();

			var productVM = new ProductVM
			{
				Id = product.Id,
				Name = product.Name,
				Price = product.Price,
				Description = product.Description,
				ImgName = product.ImgName // تأكد من وجود رابط الصورة
			};

			return Json(productVM);
		}



	}
}
