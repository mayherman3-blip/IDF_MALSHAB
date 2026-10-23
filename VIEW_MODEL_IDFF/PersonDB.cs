using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;

namespace VIEW_MODEL_IDFF
{
    public class PersonDB : BaseDB
    {
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Person";
            PersonList personList = new PersonList(base.Select());
            return personList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Person p = entity as Person;
            p.PrivateName = reader["PrivateName"].ToString();
            p.FamilyName = reader["FamilyName"].ToString();
            p.PersonID = reader["PersonID"].ToString();
            p.Email = reader["email"].ToString();
            p.PhoneNumber = reader["PhoneNumber"].ToString();
            p.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
            p.StreetNumber = reader["Street&Number"].ToString();
            p.Pass = reader["Pass"].ToString();
            p.LivingCity = CitiesDB.SelectById((int)reader["LivingCity"]);
            base.CreateModel(entity);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new Person();
        }
        private static PersonList list = new PersonList();
        public static Person SelectById(int id)
        {
            PersonDB db = new PersonDB();
            list = db.SelectAll();

            Person person = list.Find(item => item.Id == id);
            return person;
        }
    }
}
