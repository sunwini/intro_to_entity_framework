

using _06_dataAccessAirport2.Models;

namespace intro_to_entity_framework.Models
{
    public class Airplane
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int MaxCountPassengers { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public AirplaneType AirplaneType { get; set; }
        public int AirplaneTypeID { get; set; }
    }
}
