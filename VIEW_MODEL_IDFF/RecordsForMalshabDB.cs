using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class RecordsForMalshabDB:BaseDB
    {
        public RecordsForMalshabList SelectAll()
        {
            command.CommandText = $"SELECT * FROM RecordsForMalshab";
            RecordsForMalshabList recordsForMalshab = new RecordsForMalshabList(base.Select());
            return recordsForMalshab;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            RecordsForMalshab r = entity as RecordsForMalshab;
            r.GettingDate = Convert.ToDateTime(reader["GettingDate"]);
            r.MalshabID = MalshabDB.SelectById((int)reader["MalshabID"]);
            r.RecordType = RecordsTypeDB.SelectById((int)reader["RecordType"]);
            base.CreateModel(entity);
            return r;
        }

        public override BaseEntity NewEntity()
        {
            return new RecordsForMalshab();
        }

        private static RecordsForMalshabList list = new RecordsForMalshabList();

        public static RecordsForMalshab SelectById(int id)
        {
            RecordsForMalshabDB db = new RecordsForMalshabDB();
            list = db.SelectAll();

            RecordsForMalshab recordsForMalshab = list.Find(item => item.Id == id);
            return recordsForMalshab;
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
            RecordsForMalshab r = entity as RecordsForMalshab;
            if (r != null)
            {
                string sqlStr = $"UPDATE RecordsForMalshab SET GettingDate=@gd, RecordType=@rt, MalshabID=@mid WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@gd", r.GettingDate));
                command.Parameters.Add(new OleDbParameter("@rt", r.RecordType.Id));
                command.Parameters.Add(new OleDbParameter("@mid", r.MalshabID.Id));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}
