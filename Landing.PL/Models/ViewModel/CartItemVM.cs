using VivaStore.DAL.Models;

namespace Landing.PL.Models.ViewModel
{
	public class CartItemVM
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public decimal Total => Price * Quantity;
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
