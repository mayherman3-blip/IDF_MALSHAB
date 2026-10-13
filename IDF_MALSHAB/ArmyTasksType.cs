using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ArmyTasksType:BaseEntity
    {
        private string taskType;

        public string TaskType { get => taskType; set => taskType = value; }
    }
}
