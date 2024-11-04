using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string Description { get; set; }
        public string ImgName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Product> Products { get; set; }

        public object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
