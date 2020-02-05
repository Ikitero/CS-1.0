using CS_1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.ViewModels
{
    public class RecordViewModel
    {
        public IEnumerable<Record> Records { get; set; }
        public string CurrentCategory { get; set; }
    }
}