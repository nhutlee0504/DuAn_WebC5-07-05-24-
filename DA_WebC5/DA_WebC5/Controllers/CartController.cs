using Microsoft.AspNetCore.Mvc;

namespace DA_WebC5.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
