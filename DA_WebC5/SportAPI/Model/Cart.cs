using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportAPI.Model
{
    public class Cart
    {
        [Key]
        public int IDCart { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        [ForeignKey("Account")]
        public string UserName { get; set; }

        [ForeignKey("ProductDetails")]
        public int IDPDetail { get; set; }

        public int Quantity { get; set; }

        public Account Account { get; set; }

        public ProductDetails ProductDetails { get; set; }
    }
}
