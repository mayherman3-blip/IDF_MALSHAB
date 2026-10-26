using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class GradesForArmyTasksDB:BaseDB
    {
        public GradesForArmyTasksList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GradesForArmyTasks";
            GradesForArmyTasksList gradesForArmyTasks = new GradesForArmyTasksList(base.Select());
            return gradesForArmyTasks;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GradesForArmyTasks g = entity as GradesForArmyTasks;
            g.Grade = Convert.ToInt32(reader["Grade"].ToString());
            g.MalshabID = MalshabDB.SelectById((int)reader["MalshabID"]);
            g.ArmyTasksType = ArmyTasksTypeDB.SelectById((int)reader["ArmyTaskType"]);
            base.CreateModel(entity);
            return g;
        }

        public override BaseEntity NewEntity()
        {
            return new GradesForArmyTasks();
        }

        private static GradesForArmyTasksList list = new GradesForArmyTasksList();

        public static GradesForArmyTasks SelectById(int id)
        {
            GradesForArmyTasksDB db = new GradesForArmyTasksDB();
            list = db.SelectAll();

            GradesForArmyTasks gradesForArmyTasks = list.Find(item => item.Id == id);
            return gradesForArmyTasks;
        }
    }
}
