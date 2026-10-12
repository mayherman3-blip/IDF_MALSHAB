using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ParentList:List<Parent>
    {
        public ParentList() { }
        public ParentList(IEnumerable<Parent> list) : base(list) { }
        public ParentList(IEnumerable<BaseEntity> list) : base(list.Cast<Parent>().ToList()) { }

    }
}
