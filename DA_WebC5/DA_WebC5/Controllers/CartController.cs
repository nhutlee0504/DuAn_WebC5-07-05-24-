using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            string username = HttpContext.Session.GetString("LoggedInUser");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Username = username;
            return View(_context.Carts.Where(x => x.UserName == username)
                .Include(x => x.Account).Include(y => y.ProductDetails.Product.Category).Include(y => y.ProductDetails.Sizes).Include(y => y.ProductDetails.Colors));
        }

        public IActionResult AddCart(int IdPDetail, int quantity)
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
                    Quantity = quantity
                };
                _context.Carts.Add(cart);
                _context.SaveChanges();
                var pd = _context.Products.Where(x => x.IDProduct == prod.IDProduct).Select(x => x.Name);
                var hs = new History()
                {
                    UserName = username,
                    Describe = "Đã thêm sản phẩm " + pd.ToString() + " vào giỏ hàng vào " + DateTime.Now,
                };
                _context.Histories.Add(hs);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult AddOne(int id)
        {
            var prod = _context.Carts.FirstOrDefault(x => x.IDCart == id);
            if (prod != null) 
            {
                prod.Quantity++;
                _context.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        public IActionResult SubtractOne(int id)
        {
            var prod = _context.Carts.FirstOrDefault(x => x.IDCart == id);
            if (prod != null)
            {
                if (prod.Quantity > 1)
                {
                    prod.Quantity--;
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
              
            }
            return NotFound();
        }

        public IActionResult DeleteAll()
        {
            string username = HttpContext.Session.GetString("LoggedInUser");
            var carts = _context.Carts.Where(x => x.UserName == username).ToList();
            _context.RemoveRange(carts);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteProd(int id)
        {
            var prod = _context.Carts.Find(id);
            _context.Remove(prod);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
