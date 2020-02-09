using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_1._0.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS_1._0.Controllers
{
    public class CategoryController : Controller
    {
        // GET: /<controller>/
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult AddingComplete()
        {
            ViewBag.CompleteMessage = "Category was succesfully created!";
            return View("AddingComplete");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult RemoveCategory()
        {
            var model = _categoryRepository.AllCategories;
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult RemoveCategory(int categoryId)
        {
            _categoryRepository.RemoveCategory(categoryId);
            var model = _categoryRepository.AllCategories;
            return View(model);
        }
    }
}
