using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class SaleResponse : ISale
    {
        private readonly ApplicationDbContext context;
        public SaleResponse(ApplicationDbContext ct) => context = ct;
        public Sale AddSale(Sale sale)
        {
            try
            {
                context.Sales.Add(sale);
                context.SaveChanges();
                return sale;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public IEnumerable<Sale> GetSale()
        {
            return context.Sales ;
        }

        public Sale GetSaleByID(int id)
        {
            return context.Sales.FirstOrDefault(c => c.IDSale == id);
        }

        public Sale GetSaleByName(string name)
        {
            return context.Sales.FirstOrDefault(c => c.Name.Equals(name));
        }
    }
}
