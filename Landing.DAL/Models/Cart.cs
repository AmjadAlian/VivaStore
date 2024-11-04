using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
		public decimal? TotalAmount { get; set; }

		public decimal CalculateTotal()
        {
            return CartItems.Sum(item => item.Product.Price * item.Quantity);
        }
    }
}
