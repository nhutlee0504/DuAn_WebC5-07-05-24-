using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public interface ICategory
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategoryById(int id);
        public Category AddCategory(Category category);
        public Category UpdateCategory(int id,Category category);

    }
}
