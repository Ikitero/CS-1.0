using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public interface IRecordRepository
    {
        IEnumerable<Record> Records {get;}
        Record GetRecordByRecordId(int recordId);
        void CreateRecord(Record record);
        void RemoveRecord(Record record);
    }
}
