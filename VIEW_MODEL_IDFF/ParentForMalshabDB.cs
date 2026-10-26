using IDF_MALSHAB;
using System;
using System.Collections.Generic;
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
    }
}
