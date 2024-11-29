namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
	public class ProductVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public bool IsNew { get; set; }
		public int Stock { get; set; }
		public string? ImgName { get; set; }
		public List<string>? AdditionalImgNames { get; set; } = new List<string>();
		public List<string> Colors { get; set; }
		public List<string> Sizes { get; set; }
		public string CategoryName { get; set; }
		
		public decimal? DiscountPrice { get; set; }

		public decimal DiscountPercentage
		{
			get
			{
				if (DiscountPrice.HasValue && DiscountPrice < Price)
				{
					decimal finalPrice = Price - DiscountPrice.Value;
					return (int)((1- (finalPrice / Price)) * 100);
				}
				return 0;
			}
		}
	}
}
