using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class SubjectsForMalshabDB:BaseDB
    {
        public SubjectsForMalshabList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SubjectsForMalshab";
            SubjectsForMalshabList subjectsForMalshab = new SubjectsForMalshabList(base.Select());
            return subjectsForMalshab;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            SubjectsForMalshab s = entity as SubjectsForMalshab;
            s.Points = Convert.ToInt32(reader["Points"].ToString());
            s.FinalGrade = Convert.ToInt32(reader["FinalGrade"].ToString());
            s.MalshabID = MalshabDB.SelectById((int)reader["MalshabID"]);
            s.SubjectsType = SubjectsTypeDB.SelectById((int)reader["SubjectsType"]);
            base.CreateModel(entity);
            return s;
        }

        public override BaseEntity NewEntity()
        {
            return new SubjectsForMalshab();
        }

        private static SubjectsForMalshabList list = new SubjectsForMalshabList();

        public static SubjectsForMalshab SelectById(int id)
        {
            SubjectsForMalshabDB db = new SubjectsForMalshabDB();
            list = db.SelectAll();

            SubjectsForMalshab subjectsForMalshab = list.Find(item => item.Id == id);
            return subjectsForMalshab;
        }
    }
}
