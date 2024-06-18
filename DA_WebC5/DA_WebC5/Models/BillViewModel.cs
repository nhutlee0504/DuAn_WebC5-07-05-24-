using System.Collections.Generic;

namespace DA_WebC5.Models
{
    public class BillViewModel
    {
        public Account User { get; set; }
        public IEnumerable<Cart> CartItems { get; set; }
        public decimal TotalPriceInput { get; set; }

	}
}
