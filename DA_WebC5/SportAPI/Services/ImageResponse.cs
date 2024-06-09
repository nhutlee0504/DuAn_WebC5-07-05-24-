using Microsoft.EntityFrameworkCore;
using SportAPI.Data;
using SportAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class ImageResponse : IImage
    {
       private readonly ApplicationDbContext context;
		public ImageResponse(ApplicationDbContext ct) => context = ct;

		public IEnumerable<ImageDetails> GetImages(int productId)
		{
			return context.ImageDetails.Where(x => x.IDProduct == productId);
		}
	}
}
