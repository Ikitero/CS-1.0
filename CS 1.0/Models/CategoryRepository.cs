using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => _appDbContext.Categories;

        public void AddCategory(Category category)
        {
            var categories = _appDbContext.Categories.ToList();
            var temp = categories.Where(c => c.CategoryName == category.CategoryName).ToList();
            if (temp==null)
            {
                _appDbContext.Categories.Add(category);
                _appDbContext.SaveChanges();
            }
        }


        public void RemoveCategory(int categoryId)
        {
            var category = _appDbContext.Categories.Single(c => c.CategoryId == categoryId);
            if (category != null)
            {
                _appDbContext.Categories.Remove(category);
                _appDbContext.SaveChanges();
            }
        }
    }
}
