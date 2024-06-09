using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Services;
using System.Collections.Generic;

namespace SportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageDetailController : ControllerBase
    {
        private IImage image;
        public ImageDetailController(IImage img) => image = img;

        [HttpGet]
		public IEnumerable<ImageDetails> GetImageDetails(int productId)
		{
			return image.GetImages(productId);
		}
	}
}
