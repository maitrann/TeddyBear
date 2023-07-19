using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyBear.Models
{
    [Table("Size")]
    public class Size
    {
        [Key]
        public int Id { get; set; }
        public int Length { get; set; }
    }
}
