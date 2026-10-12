using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class StatusType:BaseEntity
    {
        private string status;

        public string Status { get => status; set => status = value; }
    }
}
