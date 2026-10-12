using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class ParentForMalshab:BaseEntity
    {
        private Malshab malshab;
        private Parent parent;

        public Malshab Malshab { get => malshab; set => malshab = value; }
        public Parent Parent { get => parent; set => parent = value; }
    }
}
