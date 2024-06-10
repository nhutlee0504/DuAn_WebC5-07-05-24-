using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportAPI.Model
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
