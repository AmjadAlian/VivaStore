using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class ProductFormVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Please enter a valid price")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public IFormFile Img { get; set; }
        public string? ImgName { get; set;}
		public List<IFormFile> AdditionalImages { get; set; } = new List<IFormFile>();
		public List<string>? AdditionalImgNames { get; set; } = new List<string>();
        public List<string> DeleteAdditionalImages { get; set; } = new List<string>();

        public bool IsActive { get; set; }
        public string? CategoryName { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int? CategoryId { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }
    }
}
