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
            Person p = entity as Person;
            if (p != null)
            {
                string sqlStr = $"UPDATE Person SET PersonID=@pid, PrivateName=@pn, FamilyName=@fn, email=@e, PhoneNumber=@phn, BirthDate=@bid, LivingCity=@lc, Street&Number=@stn, Pass=@pa WHERE ID=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", p.PersonID));
                command.Parameters.Add(new OleDbParameter("@pn", p.PrivateName));
                command.Parameters.Add(new OleDbParameter("@fn", p.FamilyName));
                command.Parameters.Add(new OleDbParameter("@e", p.Email));
                command.Parameters.Add(new OleDbParameter("@phn", p.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@bid", p.BirthDate));
                command.Parameters.Add(new OleDbParameter("@lc", p.LivingCity.Id));
                command.Parameters.Add(new OleDbParameter("@stn", p.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@pa", p.Pass));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }
    }
}
