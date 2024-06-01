using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA_WebC5.Models
{
    public class Evaluate
    {
        [Key]
        public int IDEvaluate { get; set; }

        [ForeignKey("Account")]

        [Column(TypeName = "varchar(20)")]
        public string UserName { get; set; }

        [ForeignKey("Product")]
        public int IDProduct { get; set; }

        public int? Point { get; set; }

        [Column(TypeName = "ntext")]
        public string Describe { get; set; }

        public Account Account { get; set; }

        public Product Product { get; set; }
    }
}
