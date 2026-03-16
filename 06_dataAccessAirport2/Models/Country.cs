using System;
using System.Collections.Generic;
using System.Text;

namespace _06_dataAccessAirport2.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public ICollection<City> Cities { get; set; }

    }
}
