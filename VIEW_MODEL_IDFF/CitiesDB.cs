using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;


namespace VIEW_MODEL_IDFF
{
    public class CitiesDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new Cities();
        }

        public CitiesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Cities";
            CitiesList citiesLst = new CitiesList(base.Select());
            return citiesLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cities c = entity as Cities;
            c.CityName = reader["CityName"].ToString();
            base.CreateModel(entity);
            return entity;
        }

    }
}
