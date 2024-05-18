using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DA_WebC5.Models
{
    public class Sizes
    {
        [Key]
        public int IDSize { get; set; }

        [Required] 
        public string SizeName { get; set; }

        public ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
