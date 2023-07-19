using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyBear.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? IdCate { get; set; }
        public Category? Category_Parent { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
