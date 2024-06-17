using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public class BillResponse : IBill
    {
        private readonly ApplicationDbContext _context;
        public BillResponse(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bill> GetAllBill()
        {
            return _context.Bills;
        }
    }
}
