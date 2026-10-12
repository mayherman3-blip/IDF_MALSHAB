using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class Malshab:Person
    {
        private DateTime giyusDate;
        private StatusType status;
        private string shibutz;

        public DateTime GiyusDate { get => giyusDate; set => giyusDate = value; }
        public StatusType Status { get => status; set => status = value; }
        public string Shibutz { get => shibutz; set => shibutz = value; }
    }
}
