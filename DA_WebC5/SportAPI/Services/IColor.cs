using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IColor
    {
        public IEnumerable<Colors> GetColors();
    }
}
