using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface IColor
    {
        public IEnumerable<Colors> GetColors();
        public Colors AddColor(Colors colors);
        public Colors GetColorById(int id);
        public Colors UpdateColor(int id, Colors colors);
    }
}
