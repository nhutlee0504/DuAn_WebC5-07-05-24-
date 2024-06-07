using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAPI.Model
{
    public class Account
    {
        [Key, Column(TypeName = "varchar(20)")]
        public string UserName { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required, EmailAddress, Column(TypeName = "varchar(150)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "nvarchar(20)")]
        public string Role { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Column(TypeName = "nvarchar(3)")]
        public string Gender { get; set; }


        [Required, Column(TypeName = "varchar(12)")]
        public string Phone { get; set; }

        [Required, Column(TypeName = "ntext")]
        public string Address { get; set; }

        public ICollection<Cart> carts { get; set; }
        
        public ICollection<History> histories { get; set; }

        public ICollection<Bill> bills { get; set; }

        public ICollection<SaleDetails> SaleDetails { get; set; }
        public ICollection<Evaluate> evaluates { get; set; }
    }
}
