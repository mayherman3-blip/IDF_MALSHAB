using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class GradesForArmyTasksList:List<GradesForArmyTasks>
    {
        public GradesForArmyTasksList() { }
        public GradesForArmyTasksList(IEnumerable<GradesForArmyTasks> list) : base(list) { }
        public GradesForArmyTasksList(IEnumerable<BaseEntity> list) : base(list.Cast<GradesForArmyTasks>().ToList()) { }

    }
}
