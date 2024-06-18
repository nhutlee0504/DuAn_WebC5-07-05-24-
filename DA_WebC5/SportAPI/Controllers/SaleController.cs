using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportAPI.Data;
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
        private readonly ISale _saleService;
        private readonly ApplicationDbContext _context;

        public SaleController(ISale saleService, ApplicationDbContext context)
        {
            _saleService = saleService;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Sale> GetSales()
        {
            return _saleService.GetSale();
        }

        [HttpPost]
        public ActionResult<Sale> AddSale(Sale sale)
        {
            var addedSale = _saleService.AddSale(sale);
            return CreatedAtAction(nameof(GetSaleName), new { name = addedSale.Name }, addedSale);
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Sale>> GetSaleName(string name)
        {
            var sale1 = await _context.Sales.FirstOrDefaultAsync(x => x.Name == name);

            if (sale1 == null)
            {
                return NotFound();
            }

            return sale1;
        }
    }
}
