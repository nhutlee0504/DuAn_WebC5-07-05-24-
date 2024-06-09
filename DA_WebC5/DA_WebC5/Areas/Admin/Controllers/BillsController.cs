using DA_WebC5.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DA_WebC5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BillsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("Admin/Bills/Index")]
        public IActionResult Index()
        {
            var list = _context.Bills.ToList();
            return View(list);
        }
    }
}
