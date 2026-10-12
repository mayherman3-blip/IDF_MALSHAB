using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ArmyTaskTypeList:List<ArmyTaskType>
    {
        public ArmyTaskTypeList() { }
        public ArmyTaskTypeList(IEnumerable<ArmyTaskType> list) : base(list) { }
        public ArmyTaskTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<ArmyTaskType>().ToList()) { }

    }
}
