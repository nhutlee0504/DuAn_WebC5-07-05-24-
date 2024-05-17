using DA_WebC5.Data;
using Microsoft.AspNetCore.Mvc;

namespace DA_WebC5.Controllers
{
    public class ProductDetailController : Controller
    {
        private ApplicationDbContext _context;
        public ProductDetailController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
