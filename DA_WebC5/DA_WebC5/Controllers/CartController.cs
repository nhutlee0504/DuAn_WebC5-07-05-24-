using DA_WebC5.Data;
using Microsoft.AspNetCore.Mvc;

namespace DA_WebC5.Controllers
{
	public class CartController : Controller
	{
		private readonly ApplicationDbContext _context;
		public CartController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
