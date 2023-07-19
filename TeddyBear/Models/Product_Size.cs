﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyBear.Models
{
    [Table("Product_Size")]
    [Keyless]
    public class Product_Size
    {
        public int IdProduct { get; set; }
        public Product Product { get; set; } = null!;
        public int IdSize { get; set; }
        [ForeignKey("IdSize")]
        public Size Size { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
    }
}
