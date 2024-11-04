using VivaStore.DAL.Models;
using VivaStore.PL.Areas.Dashboard.ViewModels;

namespace Landing.PL.Models.ViewModel
{
	public class HomePageViewModel
	{
		public List<SliderHomeVM> Sliders { get; set; } = new List<SliderHomeVM>();
		public List<ProductVM> Products { get; set; } = new List<ProductVM>();
		public List<CategoryVM> Categories { get; set; } = new List<CategoryVM>();
		public List<CartItemVM> CartItems { get; set; } = new List<CartItemVM>();
		public int ItemCount => CartItems?.Count ?? 0;
		public ProductVM SelectedProduct { get; set; }
		public int CurrentPage { get; set; } = 1;
		public int TotalPages { get; set; }
		public int? SelectedCategoryId { get; set; } // ID الفئة المختارة
	}

}
