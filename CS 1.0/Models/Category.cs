using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class Category
    {
        public int CategoryId {get;set;}
        public string CategoryName { get; set; }
        public List<Record> Records { get; set; }
    }
}
