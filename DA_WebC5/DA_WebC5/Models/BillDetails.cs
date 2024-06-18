using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA_WebC5.Models
{
    public class BillDetails
    {
        [Key]
        public int IDBDetail { get; set; }

        [ForeignKey("Bill")]
        public int IDBill { get; set; }

        [ForeignKey("ProductDetails")]
        public int IDPDetail { get; set; }
        
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Bill Bill { get; set; }

        public ProductDetails ProductDetails { get; set; }
    }
}
