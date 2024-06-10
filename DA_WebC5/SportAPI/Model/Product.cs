using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAPI.Model
{
    public class Product
    {
        [Key]
        public int IDProduct { get; set; }

        [ForeignKey("Supplier")]
        public int IDSupplier { get; set; }

        [ForeignKey("Category")]
        public int IDCategory { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        [Required, Column(TypeName = "nvarchar(10)")]
        public string Status { get; set; }

        public Supplier Supplier { get; set; }
        
        public Category Category { get; set; }

        public ICollection<ImageDetails> ImageDetails { get; set; }

        public ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
