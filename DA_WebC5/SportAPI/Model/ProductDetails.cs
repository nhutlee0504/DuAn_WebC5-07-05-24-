using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAPI.Model
{
    public class ProductDetails
    {
        [Key]
        public int IDPDetail { get; set; }

        [ForeignKey("Product")]
        public int IDProduct { get; set; }

        [ForeignKey("Sizes")]
        public int Size { get; set; }

        [ForeignKey("Colors")]
        public int IDColor { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }
        public Sizes Sizes { get; set; }

        public Colors Colors { get; set; }

        public ICollection<Cart> Carts { get; set; }

        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
