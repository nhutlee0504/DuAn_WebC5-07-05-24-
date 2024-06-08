using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
			if (IdPDetail == 0)
			{
                return NotFound();
            }
			var cart = new Cart
			{
				IDPDetail = IdPDetail,
				UserName = "minh123",
				Quantity = 3
			};
			_context.Carts.Add(cart);
			_context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
	}
}
