﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaStore.DAL.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
