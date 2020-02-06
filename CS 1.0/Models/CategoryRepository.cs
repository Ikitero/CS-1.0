﻿using System;
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
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }


        public void RemoveCategory(Category category)
        {
            _appDbContext.Categories.Remove(category);
            _appDbContext.SaveChanges();
        }
    }
}
