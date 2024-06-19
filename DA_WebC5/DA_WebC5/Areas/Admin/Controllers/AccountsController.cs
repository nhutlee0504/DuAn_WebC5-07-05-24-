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

		[Route("Admin/Accounts/History")]
		public IActionResult History(string id)
		{
			var list = _context.Histories.Where(x => x.UserName == id).ToList();
			return View(list);
		}
        [Route("Admin/Accounts/BanAccount")]
        public IActionResult BanAccount(string id)
        {
            var user = _context.Accounts.Where(x => x.UserName == id).FirstOrDefault();
            if (user != null)
            {
                user.Role = "Blocked";
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
