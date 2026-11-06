using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;


namespace VIEW_MODEL_IDFF
{
    public class SubjectsTypeDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new SubjectsType();
        }

        public SubjectsTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SubjectsType";
            SubjectsTypeList subjectsTypeLst = new SubjectsTypeList(base.Select());
            return subjectsTypeLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            SubjectsType st = entity as SubjectsType;
            st.SubjectName = reader["SubjectName"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public static List<SubjectsType> list;
        public static SubjectsType SelectById(int id)
        {
            SubjectsTypeDB db = new SubjectsTypeDB();
            list = db.SelectAll();

            SubjectsType subjectstype_ = list.Find(item => item.Id == id);

            return subjectstype_;
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
            SubjectsType s = entity as SubjectsType;
            if (s != null)
            {
                string sqlStr = $"UPDATE SubjectsType SET SubjectName=@s WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@s", s.SubjectName));
                command.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
        }
    }
}


