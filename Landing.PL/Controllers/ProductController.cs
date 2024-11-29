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
		public async Task<IActionResult> Index(int page = 1, int? categoryId = null, string searchTerm = "")
		{
			const int pageSize = 10;

			IQueryable<Product> productQuery = context.Products
				.Where(p => p.IsActive)
				.Include(p => p.Category);

			if (!string.IsNullOrEmpty(searchTerm))
			{
				productQuery = productQuery.Where(p => p.Name.Contains(searchTerm)); // البحث باستخدام الاسم
			}

			if (categoryId.HasValue)
			{
				productQuery = productQuery.Where(p => p.CategoryId == categoryId.Value);
			}

			var totalProducts = await productQuery.CountAsync();
			var totalPages = (int)Math.Ceiling((double)totalProducts / pageSize);

			var productEntities = await productQuery
				.Skip((page - 1) * pageSize)
				.Take(pageSize)
				.ToListAsync();
			var productViewModels = mapper.Map<List<ProductVM>>(productEntities);

			// استعلام الفئات
			var CategoryEntities = await context.Categories
				.Where(s => s.IsActive)
				.OrderBy(s => s.Order)
				.ToListAsync();
			var CategoryViewModels = mapper.Map<List<CategoryVM>>(CategoryEntities);

			// إعداد الـ ViewModel
			var homeViewModel = new HomePageViewModel
			{
				
				Products = productViewModels,
				Categories = CategoryViewModels,
				CurrentPage = page,
				TotalPages = totalPages,
				SelectedCategoryId = categoryId,
				SearchTerm = searchTerm
			};

			return View(homeViewModel);
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
			var product = context.Products.Find(id); 
			if (product == null)
				return NotFound();

			var productVM = new ProductVM
			{
				Id = product.Id,
				Name = product.Name,
				Price = product.Price,
				Description = product.Description,
				ImgName = product.ImgName,
				Colors=product.Colors?? new List<string>(),
				Sizes=product.Sizes ?? new List<string>(),
				
			};

			return Json(productVM);
		}



	}
}
