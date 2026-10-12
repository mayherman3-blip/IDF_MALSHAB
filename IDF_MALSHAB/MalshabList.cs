using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class MalshabList:List<Malshab>
    {
        public MalshabList() { }
        public MalshabList(IEnumerable<Malshab> list) : base(list) { }
        public MalshabList(IEnumerable<BaseEntity> list) : base(list.Cast<Malshab>().ToList()) { }

    }
}
