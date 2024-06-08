using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public class SupplierResponse:ISupplier
    {
        private readonly ApplicationDbContext context;
        public SupplierResponse(ApplicationDbContext ct) => context = ct;

        public IEnumerable<Supplier> GetSuppliers()
        {
           return context.Suppliers;
        }
    }
}
