using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class GradesForArmyTasks:BaseEntity
    {
        private ArmyTasksType armyTasksType;
        private int grade;
        private Malshab malshabID;

        public ArmyTasksType ArmyTasksType { get => armyTasksType; set => armyTasksType = value; }
        public int Grade { get => grade; set => grade = value; }
        public Malshab MalshabID { get => malshabID; set => malshabID = value; }
    }
}
