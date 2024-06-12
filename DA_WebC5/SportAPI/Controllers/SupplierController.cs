using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;
using System.Drawing;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplier supplier;
        public SupplierController(ISupplier supp) => supplier = supp;

        [HttpGet]
        public IEnumerable<Supplier> GetSuppliers()
        {
            return supplier.GetSuppliers();
        }
        [HttpPost]
        public Supplier Add(Supplier sup)
        {
            return supplier.Addsuplire(new Supplier
            {
               Name = sup.Name,
               Address = sup.Address,
               Phone = sup.Phone,
               Email = sup.Email
            });
        }
    }
}
