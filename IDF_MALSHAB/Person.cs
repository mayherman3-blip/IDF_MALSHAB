using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class Person:BaseEntity
    {
        private string personID;
        private string privateName;
        private string familyName;
        private string email;
        private string phoneNumber;
        private DateTime birthDate;
        private Cities livingCity;
        private string pass;

        public string PersonID { get => personID; set => personID = value; }
        public string PrivateName { get => privateName; set => privateName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public Cities LivingCity { get => livingCity; set => livingCity = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
