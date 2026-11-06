using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;

namespace VIEW_MODEL_IDFF
{
    public class ArmyTasksTypeDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new ArmyTasksType();
        }

        public ArmyTasksTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ArmyTasksType";
            ArmyTasksTypeList armyTasksTypeLst = new ArmyTasksTypeList(base.Select());
            return armyTasksTypeLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ArmyTasksType att = entity as ArmyTasksType;
            att.TaskType = reader["TaskType"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public static ArmyTasksType SelectById(int id)
        {
            ArmyTasksTypeDB db = new ArmyTasksTypeDB();
            List<ArmyTasksType> list = db.SelectAll();

            ArmyTasksType armytaskstype_ = list.Find(item => item.Id == id);

            return armytaskstype_;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ArmyTasksType a = entity as ArmyTasksType;
            if (a != null)
            {
                string sqlStr = $"UPDATE ArmyTasksType SET TaskType=@tasktype WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@tasktype", a.TaskType));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
    }
}
