using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailController : ControllerBase
    {
        private IBillDetail bid;
        public BillDetailController(IBillDetail s) => bid = s;
        [HttpGet("{id}")]
        public IActionResult GetBillDetails(int id)
        {
            var billDetails = bid.GetBillDetails(id); // Lấy danh sách BillDetails từ dịch vụ hoặc repository

            // Kiểm tra nếu không tìm thấy hóa đơn
            if (billDetails == null)
            {
                return NotFound();
            }

            try
            {
                // Tạo một view model để chứa các thông tin cần thiết để hiển thị
                var viewModel = billDetails.Select(bd => new
                {
                    bd.IDBDetail,
                    bd.IDBill,
                    bd.IDPDetail,
                    bd.Quantity,
                    bd.Price,
                    Product = new
                    {
                        IDProduct = bd.ProductDetails != null ? bd.ProductDetails.IDProduct : 0,
                        Name = bd.ProductDetails != null && bd.ProductDetails.Product != null ? bd.ProductDetails.Product.Name : null,
                        Image = bd.ProductDetails != null && bd.ProductDetails.Product != null ? bd.ProductDetails.Product.Image : null,
                        Color = bd.ProductDetails != null && bd.ProductDetails.Colors != null ? bd.ProductDetails.Colors.Color : null,
                        Size = bd.ProductDetails != null && bd.ProductDetails.Sizes != null ? bd.ProductDetails.Sizes.SizeName : null
                    }
                });

                return Ok(viewModel); // Trả về thông tin hóa đơn dưới dạng JSON
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
        [HttpGet]
        public IEnumerable<BillDetails> GetBDID(int id)
        {
            return bid.GetBillDetailsForAdmin(id);
        }

    }
}
