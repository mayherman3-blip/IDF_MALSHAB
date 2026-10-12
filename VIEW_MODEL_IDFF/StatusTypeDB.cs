using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;

namespace VIEW_MODEL_IDFF
{
    public class StatusTypeDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new StatusType();
        }

        public StatusTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM StatusType";
            StatusTypeList statusTypeLst = new StatusTypeList(base.Select());
            return statusTypeLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            StatusType st = entity as StatusType;
            st.Status = reader["Status"].ToString();
            base.CreateModel(entity);
            return entity;
        }
    }
}
