using DA_WebC5.Data;
using DA_WebC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<IActionResult> Index(List<int> selectedProducts, string SaleInput, decimal totalPrice)
        {
            if (SaleInput != null)
            {
                var FindSale = _context.Sales.FirstOrDefault(x => x.Name == SaleInput);
                if (FindSale != null && FindSale.Quantity > 0 && totalPrice > FindSale.MinAmount && totalPrice < FindSale.MaxAmount)
                {
                    ViewBag.MaGiamGia = FindSale.Name;
                }
                else
                {
                    ViewBag.MaGiamGia = null;
                }
            }
            else
            {
                ViewBag.MaGiamGia = null;
            }
            if (selectedProducts != null && selectedProducts.Count > 0)
            {
                string username = HttpContext.Session.GetString("LoggedInUser");
                if (string.IsNullOrEmpty(username))
                {
                    return RedirectToAction("Login", "Home");
                }
                var user = await _context.Accounts.FirstOrDefaultAsync(u => u.UserName == username);
                if (user == null)
                {
                    return NotFound("User not found");
                }
                var selectedCartItems = await _context.Carts
                    .Where(x => x.UserName == username && selectedProducts.Contains(x.IDPDetail))
                    .Include(x => x.ProductDetails.Product)
                    .Include(x => x.ProductDetails.Product.Category)
                    .Include(x => x.ProductDetails.Sizes)
                    .Include(x => x.ProductDetails.Colors)
                    .ToListAsync();
                var viewModel = new BillViewModel
                {
                    User = user,
                    CartItems = selectedCartItems
                };

                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }
        }

        [HttpGet]
        public async Task<IActionResult> IndexPost(List<int> selectedProducts, string SaleInput, decimal totalPrice)
        {
            try
            {
                if (string.IsNullOrEmpty(SaleInput))
                {
                    return RedirectToAction("Index", "Cart");
                }

                var findSale = await _context.Sales.FirstOrDefaultAsync(x => x.Name == SaleInput);
                if (findSale != null && findSale.Quantity > 0 && totalPrice >= findSale.MinAmount)
                {
                    ViewBag.MaGiamGia = findSale.Name;
                    ViewBag.SaleData = findSale;
                }
                else
                {
                    ViewBag.MaGiamGia = null;
                    ViewBag.SaleData = null;
                    ViewBag.ErrorMessage = "Không tìm thấy mã khuyến mãi hoặc mã không hợp lệ";
                }
                string username = HttpContext.Session.GetString("LoggedInUser");
                if (string.IsNullOrEmpty(username))
                {
                    return RedirectToAction("Login", "Home");
                }
                var user = await _context.Accounts.FirstOrDefaultAsync(u => u.UserName == username);
                if (user == null)
                {
                    return NotFound("User not found");
                }
                var selectedCartItems = await _context.Carts
                    .Where(x => x.UserName == username && selectedProducts.Contains(x.IDPDetail))
                    .Include(x => x.ProductDetails.Product)
                    .Include(x => x.ProductDetails.Product.Category)
                    .Include(x => x.ProductDetails.Sizes)
                    .Include(x => x.ProductDetails.Colors)
                    .ToListAsync();
                var viewModel = new BillViewModel
                {
                    User = user,
                    CartItems = selectedCartItems
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Lỗi xử lý yêu cầu: " + ex.Message;
                return View(new BillViewModel());
            }
        }

        [Route("Bills/Pay")]
        public IActionResult Pay(List<int> selectedProducts)
        {
            if (selectedProducts != null && selectedProducts.Count > 0)
            {
                string username = HttpContext.Session.GetString("LoggedInUser");
                decimal totalPrice = decimal.Parse(HttpContext.Request.Form["totalPrice"]);
                var selectedCartItems = _context.Carts
                    .Where(x => x.UserName == username && selectedProducts.Contains(x.IDPDetail))
                    .Include(x => x.ProductDetails.Product)
                    .Include(x => x.ProductDetails.Product.Category)
                    .Include(x => x.ProductDetails.Sizes)
                    .Include(x => x.ProductDetails.Colors)
                    .ToList();

                // Sử dụng biến 'username' ở đây để thực hiện các hành động khác
                // ...

                var addbill = new Bill
                {
                    UserName = username,
                    OrderDate = DateTime.Now,
                    TotalAmount = totalPrice,
                    Status = "Đang chờ"
                };
                _context.Bills.Add(addbill);
                _context.SaveChanges();

                int billId = addbill.IDBill;
                foreach (var cartItem in selectedCartItems)
                {
                    var billDetail = new BillDetails
                    {
                        IDBill = billId,
                        IDPDetail = cartItem.IDPDetail,
                        Quantity = cartItem.Quantity,
                        Price = cartItem.ProductDetails.Product.Price * cartItem.Quantity
                    };
                    _context.BillDetails.Add(billDetail);

                    var pd = _context.ProductDetails.FirstOrDefault(p => p.IDPDetail == cartItem.IDPDetail);
                    if (pd != null)
                    {
                        // Cập nhật số lượng sản phẩm trong ProductDetail
                        pd.Quantity -= cartItem.Quantity;

                        // Đảm bảo số lượng không âm
                        if (pd.Quantity < 0)
                        {
                            pd.Quantity = 0;
                        }

                        // Lưu thay đổi vào cơ sở dữ liệu
                        _context.ProductDetails.Update(pd);
                    }

                    _context.Carts.Remove(cartItem);
                }
                var hs = new History
                {
                    UserName = username,
                    Describe = "Đơn hàng của " + username + " đã được tạo"
                };
                _context.Histories.Add(hs);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //public IActionResult SaleSubmit(string SaleInput, decimal totalPrice)
        //{
        //    var FindSale = _context.Sales.FirstOrDefault(x => x.Name == SaleInput);
        //    if(FindSale != null && FindSale.Quantity > 0 && totalPrice > FindSale.MinAmount && totalPrice < FindSale.MaxAmount)
        //    {
        //        ViewBag.MaGiamGia = FindSale.Name;
        //        return RedirectToAction("Index");
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
