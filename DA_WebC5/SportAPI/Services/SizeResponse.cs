using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public class SizeResponse : ISize
    {
        private readonly ApplicationDbContext context;
        public SizeResponse(ApplicationDbContext ct) => context = ct;

        public IEnumerable<Sizes> GetSizes()
        {
          return context.Sizes;
        }
    }
}
