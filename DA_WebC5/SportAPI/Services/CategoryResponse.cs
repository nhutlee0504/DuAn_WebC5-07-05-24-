using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;

namespace SportAPI.Services
{
    public class CategoryResponse : ICategory
    {
        private readonly ApplicationDbContext context;
        public CategoryResponse(ApplicationDbContext ct) => context = ct;
        public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }
    }
}
