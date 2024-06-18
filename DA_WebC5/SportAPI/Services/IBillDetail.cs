using SportAPI.Model;
using System.Collections;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IBillDetail
    {
        public List<BillDetails> GetBillDetails(int id);
        public IEnumerable<BillDetails> GetBillDetailsForAdmin(int id);
    }
}
