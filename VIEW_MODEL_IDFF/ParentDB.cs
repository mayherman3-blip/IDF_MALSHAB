using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class ParentDB:PersonDB
    {
        public ParentList SelectAll()
        {
            command.CommandText = $"SELECT  Person.ID, Person.PersonID, Person.PrivateName, Person.FamilyName, Person.email, Person.PhoneNumber, Person.BirthDate, Person.LivingCity, Person.[Street&Number], Person.Pass FROM  (Parent INNER JOIN "+
                                   " Person ON Parent.ID = Person.ID)";
            ParentList parent = new ParentList(base.Select());
            return parent;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Parent p = entity as Parent;

            base.CreateModel(entity);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new Parent();
        }

        private static ParentList list = new ParentList();

        public static Parent SelectById(int id)
        {
            ParentDB db = new ParentDB();
            list = db.SelectAll();

            Parent parent = list.Find(item => item.Id == id);
            return parent;
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
            Parent p = entity as Parent;
            if (p != null)
            {
                string sqlStr = $"UPDATE Parent SET ID = @id WHERE ID = @id"; // לא עושה כלום:)
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Parent parent = entity as Parent;
            if (parent != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}
