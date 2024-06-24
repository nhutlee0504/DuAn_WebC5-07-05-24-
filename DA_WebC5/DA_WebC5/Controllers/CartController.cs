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
            if (prod == null)
            {
                return NotFound();
            }
            else if (prod.Quantity < quantity)
            {
                var IdProd = _context.ProductDetails.Where(x => x.IDPDetail == IdPDetail).Select(x => x.IDProduct).FirstOrDefault();
                TempData["FailQuantity"] = "Số lượng sản phẩm không đủ";
                return RedirectToAction("Index", "ProductDetail", new { id = IdProd });
            }

            var cartItem = _context.Carts.FirstOrDefault(x => x.IDPDetail == prod.IDPDetail && x.UserName == username);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
                if(cartItem.Quantity > _context.ProductDetails.Where(x => x.IDPDetail == IdPDetail).Select(x => x.Quantity).FirstOrDefault())
                {
                    TempData["FailQuantity"] = "Số lượng sản phẩm không đủ và sản phẩm đã có trong giỏ hàng";
                    var IdProd = _context.ProductDetails.Where(x => x.IDPDetail == IdPDetail).Select(x => x.IDProduct).FirstOrDefault();
                    return RedirectToAction("Index", "ProductDetail", new { id = IdProd });
                }
            }
            else
            {
                var cart = new Cart
                {
                    IDPDetail = prod.IDPDetail,
                    UserName = username,
                    Quantity = quantity
                };
                _context.Carts.Add(cart);
                var productName = _context.Products.Where(x => x.IDProduct == prod.IDProduct).Select(x => x.Name).FirstOrDefault();
                var history = new History
                {
                    UserName = username,
                    Describe = $"Đã thêm sản phẩm {productName} vào giỏ hàng vào {DateTime.Now}",
                };
                _context.Histories.Add(history);
            }
            _context.SaveChanges();
            TempData["SuccessAddCart"] = "Đã thêm sản phẩm vào giỏ hàng thành công";
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public IActionResult Subtract(int id)
        {
            var prod = _context.Carts.FirstOrDefault(x => x.IDCart == id);
            if (prod != null && prod.Quantity > 1)
            {
                prod.Quantity--;
                _context.SaveChanges();
                return Json(new { success = true, quantity = prod.Quantity});
            }
            return Json(new { success = false, message = "Sản phẩm có số lượng ở mức thấp nhất" });
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            var prod = _context.Carts.FirstOrDefault(x => x.IDCart == id);
            if (prod != null)
            {
                prod.Quantity++;
                if (prod.Quantity > _context.ProductDetails.Where(x => x.IDPDetail == prod.IDPDetail).Select(x => x.Quantity).FirstOrDefault())
                {
                    return Json(new { success = false, message = "Số lượng sản phẩm không đủ" });
                }
                _context.SaveChanges();
                return Json(new { success = true, quantity = prod.Quantity });
            }
            return Json(new { success = false });
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
