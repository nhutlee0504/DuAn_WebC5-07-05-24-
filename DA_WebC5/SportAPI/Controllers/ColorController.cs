using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColor color;
        public ColorController(IColor co) => color = co;

        [HttpGet]
        public IEnumerable<Colors> GetColors()
        {
            return color.GetColors();
        }
    }
}
