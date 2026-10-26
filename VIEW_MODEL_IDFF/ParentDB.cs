using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class ParentDB:PersonDB
    {
        public ParentList SelectAll()
        {
            command.CommandText = $"SELECT * SELECT        Person.ID, Person.PersonID, Person.PrivateName, Person.FamilyName, Person.email, Person.PhoneNumber, Person.BirthDate, Person.LivingCity, Person.[Street&Number], Person.Pass\r\nFROM            (Parent INNER JOIN\r\n                         Person ON Parent.ID = Person.ID)";
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
    }
}
