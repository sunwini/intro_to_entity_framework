using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace intro_to_entity_framework.Models
{
    internal class Airplane
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int MaxCountPassengers { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
