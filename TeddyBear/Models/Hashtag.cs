﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeddyBear.Models
{
    [Table("Hashtag")]
    public class Hashtag
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
    }
}
