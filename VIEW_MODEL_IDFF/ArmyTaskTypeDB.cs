using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;

namespace VIEW_MODEL_IDFF
{
    public class ArmyTaskTypeDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new ArmyTaskType();
        }

        public ArmyTaskTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ArmyTaskType";
            ArmyTaskTypeList armyTaskTypeLst = new ArmyTaskTypeList(base.Select());
            return armyTaskTypeLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ArmyTaskType att = entity as ArmyTaskType;
            att.TaskType = reader["TaskType"].ToString();
            base.CreateModel(entity);
            return entity;
        }

    }
}
