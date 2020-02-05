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

        public void CreateRecord(Record record)
        {
            _appDbContext.Records.Add(record);
            _appDbContext.SaveChanges();
        }

        public Record GetRecordByRecordId(int recordId)
        {
            return _appDbContext.Records.FirstOrDefault(r => r.RecordId == recordId);
        }

        public void RemoveRecord(Record record)
        {
            _appDbContext.Records.Remove(record);
            _appDbContext.SaveChanges();
        }
    }
}
