using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class ParentForMalshabDB:BaseDB
    {
        public ParentForMalshabList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ParentForMalshab";
            ParentForMalshabList parentForMalshab = new ParentForMalshabList(base.Select());
            return parentForMalshab;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ParentForMalshab p = entity as ParentForMalshab;
           
            p.Malshab = MalshabDB.SelectById((int)reader["Malshab"]);
            p.Parent = ParentDB.SelectById((int)reader["Parent"]);
            base.CreateModel(entity);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new ParentForMalshab();
        }

        private static ParentForMalshabList list = new ParentForMalshabList();

        public static ParentForMalshab SelectById(int id)
        {
            ParentForMalshabDB db = new ParentForMalshabDB();
            list = db.SelectAll();

            ParentForMalshab parentForMalshab = list.Find(item => item.Id == id);
            return parentForMalshab;
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
            ParentForMalshab p = entity as ParentForMalshab;
            if (p != null)
            {
                string sqlStr = $"UPDATE ParentForMalshab SET Malshab=@ma, Parent=@p WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ma", p.Malshab.Id));
                command.Parameters.Add(new OleDbParameter("@p", p.Parent.Id));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
