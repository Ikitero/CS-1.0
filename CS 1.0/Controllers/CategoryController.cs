using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_1._0.Models;
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
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
            return RedirectToAction("AddingComplete");
        }

        public IActionResult AddingComplete()
        {
            ViewBag.CompleteMessage = "Category was succesfully created!";
            return View("AddingComplete");
        }

        [HttpPost]
        public IActionResult RemoveCategory(Category category)
        {
            _categoryRepository.RemoveCategory(category);
            return View();
        }
    }
}
