using AutoMapper;
using Landing.PL.Models;
using Landing.PL.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VivaStore.DAL.Data;
using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace Landing.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context, IMapper mapper)
        {
            _logger = logger;
            context = _context;
            this.mapper = mapper;
        }

		public async Task<IActionResult> Index(int page = 1, int? categoryId = null)
		{
			const int pageSize = 10;

			
			var sliderEntities = await context.SliderHome
				.Where(s => s.IsActive)
				.OrderBy(s => s.Order)
				.ToListAsync();
			var sliderViewModels = mapper.Map<List<SliderHomeVM>>(sliderEntities);

		
			IQueryable<Product> productQuery = context.Products
				.Where(p => p.IsActive)
				.Include(p => p.Category);

			
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

			
			var CategoryEntities = await context.Categories
				.Where(s => s.IsActive)
				.OrderBy(s => s.Order)
				.ToListAsync();
			var CategoryViewModels = mapper.Map<List<CategoryVM>>(CategoryEntities);

		
			var CartItemViewModels = await context.CartItems.OrderBy(o => o.Price).ToListAsync();
			var CartItemEntities = mapper.Map<List<CartItemVM>>(CartItemViewModels);

			var homeViewModel = new HomePageViewModel
			{
				Sliders = sliderViewModels,
				Products = productViewModels,
				Categories = CategoryViewModels,
				CartItems = CartItemEntities,
				CurrentPage = page,
				TotalPages = totalPages,
				 SelectedCategoryId = categoryId
			};

			return View(homeViewModel);
		}



		


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
