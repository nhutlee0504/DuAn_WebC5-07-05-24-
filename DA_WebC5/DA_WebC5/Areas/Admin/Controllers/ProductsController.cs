using DA_WebC5.Controllers;
using DA_WebC5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace DA_WebC5.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductsController : Controller
	{

		private readonly ApplicationDbContext _context;
		public ProductsController(ApplicationDbContext context)
		{
			_context = context;
		}
		[Route("Admin/Products/Index")]
		public IActionResult Index()
		{
			var list = _context.Products.ToList();
			return View(list);
		}
        [Route("Admin/Products/Create")]
        public IActionResult Create()
		{
            var productTypes = _context.Categories.ToList();
            ViewBag.ProductTypes = new SelectList(productTypes);


            return View();
		}
	}
}
