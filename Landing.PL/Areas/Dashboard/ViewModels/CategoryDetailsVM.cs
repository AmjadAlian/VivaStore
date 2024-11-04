namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class CategoryDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgName { get; set; }
        public int? Order { get; set; }
        public List<ProductVM>? Products { get; set; }
    }
}
