using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
			return View(_context.Carts.Include(x => x.Account).Include(y => y.ProductDetails.Product));
		}

		public IActionResult AddCart(int IdPDetail)
		{
			string username = HttpContext.Session.GetString("LoggedInUser");
			if (string.IsNullOrEmpty(username))
			{
				return RedirectToAction("Login", "Home");
			}
			else if (IdPDetail == 0)
			{
                return NotFound();
            }
			var prod = _context.ProductDetails.FirstOrDefault(x => x.IDPDetail == IdPDetail);
			if (prod != null)
			{
                var cart = new Cart
                {
                    IDPDetail = prod.IDPDetail,
                    UserName = username,
                    Quantity = prod.Quantity
                };
                _context.Carts.Add(cart);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
			return View();
        }
	}
}
