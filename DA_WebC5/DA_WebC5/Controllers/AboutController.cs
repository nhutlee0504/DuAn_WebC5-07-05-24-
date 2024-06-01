using Microsoft.AspNetCore.Mvc;

namespace DA_WebC5.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
