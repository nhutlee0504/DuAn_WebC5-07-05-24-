using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

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
    }
}
