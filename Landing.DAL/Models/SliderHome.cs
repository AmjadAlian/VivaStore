using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
	public class SliderHome
	{
		public int Id { get; set; }
		public string ImgName { get; set; }
		public int Order { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Subtitle { get; set; }
		public bool IsActive { get; set; }
	}
}
