using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class SubjectsForMalshab:BaseEntity
    {
        private SubjectsType subjectsType;
        private int points;
        private int finalGrade;
        private Malshab malshabID;

        public SubjectsType SubjectsType { get => subjectsType; set => subjectsType = value; }
        public int Points { get => points; set => points = value; }
        public int FinalGrade { get => finalGrade; set => finalGrade = value; }
        public Malshab MalshabID { get => malshabID; set => malshabID = value; }
    }
}
