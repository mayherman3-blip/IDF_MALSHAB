using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class RecordsForMalshab:BaseEntity
    {
        private DateTime gettingDate;
        private RecordsType recordType;
        private Malshab malshabID;

        public DateTime GettingDate { get => gettingDate; set => gettingDate = value; }
        public RecordsType RecordType { get => recordType; set => recordType = value; }
        public Malshab MalshabID { get => malshabID; set => malshabID = value; }
    }
}
