using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DA_WebC5.Models
{
    public class SaleDetails
    {
        [Key]
        public int IDSaleDetail { get; set; }

        [ForeignKey("Sale")]
        public int IDSale { get; set; }

        [ForeignKey("Account")]
        [Column(TypeName = "varchar(20)")]
        public string UserName { get; set; }

        public Sale Sale { get; set; }

        public Account Account { get; set; }
    }
}
