using SportAPI.Model;
using System.Collections;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IBill
    {
        public IEnumerable<Bill> GetAllBill();

        public Bill GetBillId(int id);
    }
}
