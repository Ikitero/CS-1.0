using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_1._0.Models
{
    public class RecordTypeRepository : IRecordTypeRepository
    {
        private readonly AppDbContext _appDbContext;
        public RecordTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<RecordType> recordTypes => _appDbContext.RecordTypes;
    }
}
