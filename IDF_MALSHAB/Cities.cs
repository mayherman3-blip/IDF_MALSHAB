using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_MALSHAB
{
    public class Cities:BaseEntity
    {
        private string cityName;

        public string CityName { get => cityName; set => cityName = value; }
    }
}
