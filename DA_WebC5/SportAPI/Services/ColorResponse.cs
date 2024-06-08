using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public class ColorResponse : IColor
    {
        private readonly ApplicationDbContext context;
        public ColorResponse(ApplicationDbContext ct) => context = ct;
        public IEnumerable<Colors> GetColors()
        {
           return context.Colors;
        }
    }
}
