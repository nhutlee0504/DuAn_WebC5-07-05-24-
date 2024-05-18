using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DA_WebC5.Models
{
    public class Colors
    {
        [Key]
        public int IDColor { get; set; }

        [Required]
        public string Color { get; set; }

        public ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
