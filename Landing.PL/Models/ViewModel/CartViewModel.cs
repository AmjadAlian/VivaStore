using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
	public class CartViewModel
	{
		public int CartId { get; set; }
		public List<CartItemVM> CartItems { get; set; }
		public decimal TotalAmount { get; set; }
		public int ItemCount => CartItems?.Count ?? 0;
		[Required(ErrorMessage = "Shipping address is required.")]
		public string PaymentMethod { get; set; }
		[Required(ErrorMessage = "Shipping address is required.")]
		
		public string ShippingAddress { get; set; }
	}
}
