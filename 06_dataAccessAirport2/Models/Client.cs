
using System.ComponentModel.DataAnnotations;


namespace intro_to_entity_framework.Models
{
    public class Client
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
