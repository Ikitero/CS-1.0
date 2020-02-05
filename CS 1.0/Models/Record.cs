using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string RecordHeader { get; set; }
        public string RecordDetails { get; set; }
        public string RecordImage { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string RecordType { get; set; }

    }
}
