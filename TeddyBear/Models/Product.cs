using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyBear.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int Discount { get; set; }
        public int? IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public Category? Prod_Cate { get; set; }
        public bool IsOutstanding { get; set; }
        public bool IsActive { get; set; }
    }
}
