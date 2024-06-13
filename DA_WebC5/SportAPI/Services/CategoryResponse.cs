using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportAPI.Data;
using SportAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace SportAPI.Services
{
    public class CategoryResponse : ICategory
    {
        private readonly ApplicationDbContext context;
        public CategoryResponse(ApplicationDbContext ct) => context = ct;

        public Category AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return category;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return context.Categories.FirstOrDefault(x => x.IDCategory == id);
        }

        public Category UpdateCategory(int id, Category category)
        {
            var tim = context.Categories.FirstOrDefault(x => x.IDCategory == id);
            tim.Name = category.Name;
            context.Categories.Update(tim);
            return tim;
        }
    }
}
