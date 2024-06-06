using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SportAPI.Service
{
	public class CtlSize : ISize
	{
		private readonly ApplicationDbContext _context;
		public CtlSize(ApplicationDbContext context)
		{
			_context = context;
		}
		public Sizes Addsz(Sizes size)
		{
			_context.Add(size);
			_context.SaveChanges();
			return size;
		}

		public IEnumerable<Sizes> Sz()
		{
			return _context.Sizes;
		}

		public Sizes Sz(int id)
		{
			throw new System.NotImplementedException();
		}
	}
}
