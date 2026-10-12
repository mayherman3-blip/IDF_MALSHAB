using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class RecordsForMalshabList:List<RecordsForMalshab>
    {
        public RecordsForMalshabList() { }
        public RecordsForMalshabList(IEnumerable<RecordsForMalshab> list) : base(list) { }
        public RecordsForMalshabList(IEnumerable<BaseEntity> list) : base(list.Cast<RecordsForMalshab>().ToList()) { }

    }
}
