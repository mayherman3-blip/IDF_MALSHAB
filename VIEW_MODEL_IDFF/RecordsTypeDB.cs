using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_MALSHAB;
using System.Data.OleDb;

namespace VIEW_MODEL_IDFF
{
    public class RecordsTypeDB:BaseDB
    {
        public override BaseEntity NewEntity()
        {
            return new RecordsType();
        }

        public RecordsTypeList SelectAll()
        {
            command.CommandText = $"SELECT * FROM RecordsType";
            RecordsTypeList recordsTypeLst = new RecordsTypeList(base.Select());
            return recordsTypeLst;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            RecordsType rt = entity as RecordsType;
            rt.Description = reader["Description"].ToString();
            base.CreateModel(entity);
            return entity;
        }
        public static RecordsType SelectById(int id)
        {
            RecordsTypeDB db = new RecordsTypeDB();
            List<RecordsType> list = db.SelectAll();

            RecordsType recordstype_ = list.Find(item => item.Id == id);

            return recordstype_;
        }

    }
}
