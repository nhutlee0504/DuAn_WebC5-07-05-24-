using SportAPI.Model;
using System.Collections.Generic;
using System.Drawing;

namespace SportAPI.Services
{
    public interface ISize
    {
        public IEnumerable<Sizes> GetSizes();

        public Sizes AddSize(Sizes sizes);
        public Sizes GetSizeId(int id);
        public Sizes UpdateSizes(int id, Sizes upsize);

    }
}
