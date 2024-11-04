using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
	public class OrderViewModel
	{

		[Required]
		public string PaymentMethod { get; set; }
		[Required]
		public string ShippingAddress { get; set; }
	
	}
}
