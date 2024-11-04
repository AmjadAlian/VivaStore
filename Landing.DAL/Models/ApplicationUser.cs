using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string? FullName { get; set; }
        public string? UserAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>(); 
    }
}
