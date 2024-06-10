using DA_WebC5.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DA_WebC5.wwwroot.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("Admin/Accounts/Index")]
        public IActionResult Index()
        {
            var list = _context.Accounts.ToList();
            return View(list);
        }
    }
}
