using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class RecordsTypeList:List<RecordsType>
    {
        public RecordsTypeList() { }
        public RecordsTypeList(IEnumerable<RecordsType> list) : base(list) { }
        public RecordsTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<RecordsType>().ToList()) { }

    }
}
