using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface ISupplier
    {
        public IEnumerable<Supplier> GetSuppliers();
        public Supplier Addsuplire (Supplier supplier);
        public Supplier UpdateSuplier (Supplier supplier, int id);
        public Supplier GetSupplierByID(int id);
    }
}
