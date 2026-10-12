using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class SubjectsType:BaseEntity
    {
        private string subjectName;

        public string SubjectName { get => subjectName; set => subjectName = value; }
    }
}
