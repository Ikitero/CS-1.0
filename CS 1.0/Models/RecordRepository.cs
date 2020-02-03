using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class RecordRepository : IRecordRepository
    {
        private readonly AppDbContext _appDbContext;
        public RecordRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Record> Records => _appDbContext.Records;

        public Record GetRecordByRecordId(int recordId)
        {
            return _appDbContext.Records.FirstOrDefault(r => r.RecordId == recordId);
        }
    }
}
