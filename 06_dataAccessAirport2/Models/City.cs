using intro_to_entity_framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_dataAccessAirport2.Models
{
    public class City
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
