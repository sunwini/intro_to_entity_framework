using intro_to_entity_framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_dataAccessAirport2.Models
{
    public class AirplaneType
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
        public int AirplaneID { get; set; }
        public ICollection<Airplane> Airplanes { get; set; }
    }
}
