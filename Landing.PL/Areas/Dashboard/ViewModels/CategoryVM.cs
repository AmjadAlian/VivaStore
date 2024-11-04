namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile Img { get; set; }
        public string? ImgName { get; set; }
        public int Order { get; set; }
    }
}
