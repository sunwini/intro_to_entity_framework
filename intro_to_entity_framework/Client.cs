using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace intro_to_entity_framework
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }
        public int Rating { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
