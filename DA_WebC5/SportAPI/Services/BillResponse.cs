using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

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

        public Bill GetBillId(int id)
        {
            return _context.Bills.FirstOrDefault(x => x.IDBill == id);
        }
    }
}
