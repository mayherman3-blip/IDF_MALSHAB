using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class MalshabDB:PersonDB
    {
        public MalshabList SelectAll()
        {
            command.CommandText = $"SELECT        Person.ID, Person.PersonID, Person.PrivateName, Person.FamilyName, Person.email, Person.PhoneNumber, Person.BirthDate, Person.LivingCity, Person.[Street&Number], Person.Pass, Malshab.GiyusDate, Malshab.Status, \r\n                         Malshab.Shibutz\r\nFROM            (Malshab INNER JOIN\r\n                         Person ON Malshab.ID = Person.ID)";
            MalshabList malshabLst = new MalshabList(base.Select());
            return malshabLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Malshab m = entity as Malshab;
            m.GiyusDate = Convert.ToDateTime(reader["GiyusDate"]);
            m.Status = StatusTypeDB.SelectById((int)reader["Status"]);
            m.Shibutz = reader["Shibutz"].ToString();
            base.CreateModel(entity);
            return m;
        }

        public override BaseEntity NewEntity()
        {
            return new Malshab();
        }

        private static MalshabList list = new MalshabList();

        public static Malshab SelectById(int id)
        {
            MalshabDB db = new MalshabDB();
            list = db.SelectAll();

            Malshab malshab = list.Find(item => item.Id == id);
            return malshab;
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
            Malshab m = entity as Malshab;
            if (m != null)
            {
                string sqlStr = $"UPDATE Malshab SET GiyusDate=@g, Status=@st, Shibutz=@sh WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@g", m.GiyusDate));
                command.Parameters.Add(new OleDbParameter("@st", m.Status.Id));
                command.Parameters.Add(new OleDbParameter("@sh", m.Shibutz));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Malshab m = entity as Malshab;
            if (m != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}
