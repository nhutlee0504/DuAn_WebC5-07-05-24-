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
        private readonly ISupplier supplierService;

        public SupplierController(ISupplier supplierService)
        {
            this.supplierService = supplierService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers()
        {
            var suppliers = supplierService.GetSuppliers();
            return Ok(suppliers);
        }

        [HttpPost]
        public ActionResult<Supplier> AddSupplier(Supplier supplier)
        {
            var addedSupplier = supplierService.Addsuplire(new Supplier
            {
                Name = supplier.Name,
                Address = supplier.Address,
                Phone = supplier.Phone,
                Email = supplier.Email
            });

            if (addedSupplier == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error adding supplier.");
            }

            return CreatedAtAction(nameof(GetSupplierByID), new { id = addedSupplier.IDSupplier }, addedSupplier);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSupplier(int id, Supplier supplier)
        {
            var existingSupplier = supplierService.GetSupplierByID(id);

            if (existingSupplier == null)
            {
                return NotFound();
            }

            existingSupplier.Address = supplier.Address;
            existingSupplier.Email = supplier.Email;
            existingSupplier.Phone = supplier.Phone;
            existingSupplier.Name = supplier.Name;

            var updatedSupplier = supplierService.UpdateSuplier(existingSupplier, id);

            if (updatedSupplier == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating supplier.");
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetSupplierByID(int id)
        {
            var supplier = supplierService.GetSupplierByID(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return Ok(supplier);
        }
    }
}
