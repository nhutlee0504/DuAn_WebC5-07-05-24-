using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportAPI.Model
{
    public class Bill
    {
        [Key]
        public int IDBill { get; set; }

        [Column(TypeName = "varchar(20)")]
        [ForeignKey("Account")]
        public string UserName { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public Account Account { get; set; }

        public ICollection<BillDetails> BillDetails { get; set; }
    }
}
