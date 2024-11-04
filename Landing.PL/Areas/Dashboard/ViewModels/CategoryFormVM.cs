using System.ComponentModel.DataAnnotations;

namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class CategoryFormVM
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public IFormFile Img { get; set; }
        public string? ImgName { get; set; }
        public int Order { get; set; }
        [Display(Name = "Status:")]
        public bool? IsActive { get; set; }
    }
}
