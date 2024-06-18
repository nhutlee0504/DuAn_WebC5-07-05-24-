using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface ISale
    {
        public IEnumerable<Sale> GetSale();

        public Sale AddSale(Sale sale);
        public Sale GetSaleByID(int id);
        public Sale GetSaleByName (string name);
    }
}
