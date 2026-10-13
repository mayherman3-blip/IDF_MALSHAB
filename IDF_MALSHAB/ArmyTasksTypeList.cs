using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ArmyTasksTypeList:List<ArmyTasksType>
    {
        public ArmyTasksTypeList() { }
        public ArmyTasksTypeList(IEnumerable<ArmyTasksType> list) : base(list) { }
        public ArmyTasksTypeList(IEnumerable<BaseEntity> list) : base(list.Cast<ArmyTasksType>().ToList()) { }

    }
}
