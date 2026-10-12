using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class SubjectsTypeList:List<SubjectsType>
    {
        public SubjectsTypeList() { }
        public SubjectsTypeList(IEnumerable<SubjectsType> list) : base(list) { }
        public SubjectsTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<SubjectsType>().ToList()) { }

    }
}
