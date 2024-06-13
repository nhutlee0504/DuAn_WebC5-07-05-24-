using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;
using System.Drawing;

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

        [HttpPost]
        public Sizes Add(Sizes si)
        {
            return size.AddSize(new Sizes
            {
                SizeName = si.SizeName,
            });
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Sizes si)
        {
            var updatesize = size.GetSizeId(id);


            if (updatesize == null)
            {
                return NotFound();
            }

            updatesize.SizeName = si.SizeName;
            size.UpdateSizes(id, updatesize);
            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult Getsizeid(int id)
        {
            var siz = size.GetSizeId(id);
            if (siz == null)
            {
                return NotFound();
            }
            return Ok(siz);
        }
    }
}
