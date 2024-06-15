using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private ISale sale;
        public SaleController(ISale s) => sale = s;
        [HttpGet]
        public IEnumerable<Sale> GetSales()
        {
            return sale.GetSale();
        }
        [HttpPost]
        public Sale AddSale(Sale sal)
        {
          

            return sale.AddSale(new Sale
            {
                Name = sal.Name,
                Description = sal.Description,
                DiscountValue = sal.DiscountValue,
                MinAmount = sal.MinAmount,
                MaxAmount = sal.MaxAmount,
                StartDate = sal.StartDate,
                EndDate = sal.EndDate,
                Quantity = sal.Quantity
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSaleById(int id)
        {
            var sale1 = sale.GetSaleByID(id);

            if (sale == null)
            {
                return NotFound();
            }

            return sale1;
        }

    }
}
