using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class SizeResponse : ISize
    {
        private readonly ApplicationDbContext context;
        public SizeResponse(ApplicationDbContext ct) => context = ct;

        public Sizes AddSize(Sizes sizes)
        {
            try
            {
                context.Sizes.Add(sizes);
                context.SaveChanges();
                return sizes;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        public Sizes GetSizeId(int id)
        {
            return context.Sizes.FirstOrDefault(c => c.IDSize == id);
        }

        public IEnumerable<Sizes> GetSizes()
        {
          return context.Sizes;
        }

        public Sizes UpdateSizes(int id, Sizes upsize)
        {
            var updateSize = GetSizeId(upsize.IDSize);

            if (updateSize != null)
            {
                updateSize.SizeName = upsize.SizeName;
                context.SaveChanges();
            }

            return updateSize;
        }
    }
}
