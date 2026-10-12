using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ParentForMalshabList:List<ParentForMalshab>
    {
        public ParentForMalshabList() { }
        public ParentForMalshabList(IEnumerable<ParentForMalshab> list) : base(list) { }
        public ParentForMalshabList(IEnumerable<BaseEntity> list) : base(list.Cast<ParentForMalshab>().ToList()) { }

    }
}
