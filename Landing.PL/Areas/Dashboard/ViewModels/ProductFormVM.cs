using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class ProductFormVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Please enter a valid price")]
        public decimal Price { get; set; }
        [Required]
        [Range(0 , 10000,ErrorMessage ="Please enter a valid stock 0 - 10000")]
        public int Stock { get; set; }

        [Required(ErrorMessage ="please Enter Product Image")]
        public IFormFile Img { get; set; }
        public string? ImgName { get; set; }

        public List<IFormFile>? AdditionalImages { get; set; } = new List<IFormFile>();
        public List<string>? AdditionalImgNames { get; set; } = new List<string>();
        public List<string> DeleteAdditionalImages { get; set; } = new List<string>();
        
        public List<string>? Colors { get; set; } = new List<string>();
        public List<string>? Sizes { get; set; } = new List<string>();
        public List<SelectListItem> ColorOptions { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SizeOptions { get; set; } = new List<SelectListItem>();
        public bool IsActive { get; set; }
        public string? CategoryName { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int? CategoryId { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }

        [Required(ErrorMessage = "Please enter a valid Discount 0-10000")]
        [Range(0, 10000, ErrorMessage = "Please enter a valid Discount 0-10000")]
        public decimal? DiscountPrice { get; set; } = 0;
        [Required]
        public bool IsNew { get; set; }
    }
}
