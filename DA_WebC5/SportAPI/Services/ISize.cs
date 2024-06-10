using SportAPI.Model;
using System.Collections.Generic;
using System.Drawing;

namespace SportAPI.Services
{
    public interface ISize
    {
        public IEnumerable<Sizes> GetSizes();

    }
}
