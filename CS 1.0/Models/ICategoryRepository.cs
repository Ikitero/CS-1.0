using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        public void AddCategory(Category category);
        public void RemoveCategory(int categoryId);
    }
}
