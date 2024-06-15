using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class BillDetailResponse : IBillDetail
    {
        private readonly ApplicationDbContext _context;
        public BillDetailResponse(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BillDetails> GetBillDetails(int id)
        {
            return _context.BillDetails.Where(x => x.IDBill == id);
        }
    }
}
