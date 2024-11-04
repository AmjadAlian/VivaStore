namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
	public class SliderHomeVM
	{
		public int Id { get; set; }
        public IFormFile Img { get; set; }
        public string? ImgName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Subtitle { get; set; }
		public int Order { get; set; }
		public bool IsActive { get; set; }
	}
}
