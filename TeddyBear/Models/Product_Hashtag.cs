using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using TeddyBear.Models;

namespace TeddyBear.Models
{
    [Table("Product_Hashtag")]
    [Keyless]
    public class Product_Hashtag
    {
        public int IdProduct { get; set; }
        public Product? Product { get; set; }
        public int IdHashtag { get; set; }
        public Hashtag? Hashtag { get; set; }
    }
}
