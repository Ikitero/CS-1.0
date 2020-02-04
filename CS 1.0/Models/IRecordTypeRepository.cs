using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    interface IRecordTypeRepository
    {
        IEnumerable<RecordType> recordTypes { get; }
    }
}
