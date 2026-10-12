using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class StatusTypeList:List<StatusType>
    {
        public StatusTypeList() { }
        public StatusTypeList(IEnumerable<StatusType> list) : base(list) { }
        public StatusTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<StatusType>().ToList()) { }

    }
}
