using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_1._0.Models;
using CS_1._0.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CS_1._0.Controllers
{
    public class RecordController : Controller
    {
        private readonly IRecordRepository _recordRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RecordController(ICategoryRepository categoryRepository, IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Record> records;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                records = _recordRepository.Records.OrderBy(r => r.RecordId);
                currentCategory = "All";
            }
            else
            {
                records = _recordRepository.Records.Where(r => r.Category.CategoryName == category).OrderBy(r => r.RecordId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new RecordViewModel { Records = records, CurrentCategory = currentCategory });
        }

        public IActionResult AddRecord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRecord(Record record)
        {
            _recordRepository.CreateRecord(record);
            return View();
        }

        public IActionResult RemoveRecord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemoveRecord(int recordId)
        {
            _recordRepository.RemoveRecord(recordId);
            return View("RemoveRecord");
        }

        public IActionResult Details(int id)
        {
            var record = _recordRepository.GetRecordByRecordId(id);
            if(record==null)
            {
                return NotFound();
            }
            return View(record);
        }
    }
}