using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface ICategory
    {
        public IEnumerable<Category> GetCategories();
    }
}
