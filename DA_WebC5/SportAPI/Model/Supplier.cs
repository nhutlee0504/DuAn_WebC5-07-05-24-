using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAPI.Model
{
    public class Supplier
    {
        [Key]
        public int IDSupplier { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress, Column(TypeName = "varchar(150)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(12)")]
        public string Phone {  get; set; }

        [Required, Column(TypeName = "ntext")]
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
