using IDF_MALSHAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIEW_MODEL_IDFF
{
    public class ArmyPersonDB:PersonDB
    {
        public ArmyPersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SELECT        Person.PersonID, Person.ID, Person.PrivateName, Person.FamilyName, Person.email, Person.PhoneNumber, Person.BirthDate, Person.LivingCity, Person.[Street&Number], Person.Pass\r\nFROM            (Person INNER JOIN\r\n                         ArmyPerson ON Person.ID = ArmyPerson.ID)";
            ArmyPersonList armyPerson = new ArmyPersonList(base.Select());
            return armyPerson;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ArmyPerson a = entity as ArmyPerson;
        
            base.CreateModel(entity);
            return a;
        }

        public override BaseEntity NewEntity()
        {
            return new ArmyPerson();
        }

        private static ArmyPersonList list = new ArmyPersonList();

        public static ArmyPerson SelectById(int id)
        {
            ArmyPersonDB db = new ArmyPersonDB();
            list = db.SelectAll();

            ArmyPerson armyPerson = list.Find(item => item.Id == id);
            return armyPerson;
        }
    }
}
