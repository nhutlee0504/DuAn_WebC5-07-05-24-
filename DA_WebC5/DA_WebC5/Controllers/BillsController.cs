using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_WebC5.Controllers
{
    public class BillsController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public BillsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            string username = HttpContext.Session.GetString("LoggedInUser");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Home");
            }

            // Fetch user information
            var user = await _context.Accounts.FirstOrDefaultAsync(u => u.UserName == username);
            if (user == null)
            {
                return NotFound("User not found");
            }

            // Fetch cart items
            var cartItems = await _context.Carts
                .Where(x => x.UserName == username)

                .Include(x => x.ProductDetails.Product)
                 .Include(x => x.ProductDetails.Product.Category)
                .Include(x => x.ProductDetails.Sizes)
                .Include(x => x.ProductDetails.Colors)

                .ToListAsync();

            // Create a ViewModel to pass both user and cart items to the view
            var viewModel = new BillViewModel
            {
                User = user,
                CartItems = cartItems
            };

            return View(viewModel);
        }
    }
}
