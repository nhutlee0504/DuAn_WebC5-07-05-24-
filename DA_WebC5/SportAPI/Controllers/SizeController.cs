using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Model;
using SportAPI.Service;
using System.Collections.Generic;
using System.Drawing;

namespace SportAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SizeController : ControllerBase
	{
		private readonly ISize _size;
		public SizeController(ISize sizer)
		{
			_size = sizer;
		}

		[HttpGet]
		public IEnumerable<Sizes> Get()
		{
			return _size.Sz();
		}

		[HttpPost]
		public Sizes Post(Sizes size)
		{
			return (_size.Addsz(new Sizes
			{
				SizeName = size.SizeName,
			}));
		}
	}
}
