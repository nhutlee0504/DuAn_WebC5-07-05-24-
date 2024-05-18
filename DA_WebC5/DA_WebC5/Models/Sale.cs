using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA_WebC5.Models
{
    public class Sale
    {
        [Key] 
        public int IDSale { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public int DiscountValue { get; set; }

        public int? MinAmount { get; set; }

        public int MaxAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Quantity { get; set; }

        public ICollection<SaleDetails> Details { get; set; }
    }
}
