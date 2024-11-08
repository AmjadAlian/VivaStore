﻿namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Stock { get; set; }
        public string? ImgName { get; set; }
		public List<string>? AdditionalImgNames { get; set; } = new List<string>();

		public string CategoryName { get; set; }
    }
}
