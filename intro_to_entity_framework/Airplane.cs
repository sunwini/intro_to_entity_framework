using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace intro_to_entity_framework
{
    internal class Airplane
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Model { get; set; }
        //Relationship type : one to many (1...*)

        public int MaxCountPassengers { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
