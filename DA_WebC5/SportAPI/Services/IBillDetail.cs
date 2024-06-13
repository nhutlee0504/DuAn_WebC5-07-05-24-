using SportAPI.Model;
using System.Collections;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IBillDetail
    {
        public IEnumerable<BillDetails> GetBillDetails(int id);
    }
}
