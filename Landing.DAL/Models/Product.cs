using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImgName { get; set; }
		public List<string>? AdditionalImgNames { get; set; } = new List<string>();
		public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
