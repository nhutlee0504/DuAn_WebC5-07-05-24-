using SportAPI.Model;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace SportAPI.Service
{
	public interface ISize
	{
		public IEnumerable<Sizes> Sz();

		public Sizes Sz(int id);
		public Sizes Addsz(Sizes size);
	}
}
