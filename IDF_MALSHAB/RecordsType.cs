using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class RecordsType:BaseEntity
    {
        private string description;

        public string Description { get => description; set => description = value; }
    }
}
