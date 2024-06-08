using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private ISize size;
        public SizeController(ISize s) => size = s;

        [HttpGet]
        public IEnumerable<Sizes> GetSizes()
        {
            return size.GetSizes();
        }
    }
}
