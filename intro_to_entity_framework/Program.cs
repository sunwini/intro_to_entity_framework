using intro_to_entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace intro_to_entity_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirportDbContext dbContext = new AirportDbContext();

            //dbContext.Clients.Add(new Client()
            //{
            //    Name = "Olga",
            //    Email = "olga@gmail.com",
            //    Birthdate = new DateTime(1995, 5, 14),

            //});
            //dbContext.SaveChanges();
            //foreach (var client in dbContext.Clients)
            //{
            //    Console.WriteLine($"{client.Name}. Email: {client.Email}");
            //}

            int a = 0;
            int? b = null;

            var flights = dbContext.Flights
                .Include(f=>f.Airplane)
                .Where(f => f.ArrivalCity == "kyiv")
                .OrderBy(f => f.ArrivalTime);
            foreach (var flight in flights)
            {
                Console.WriteLine($"From : {flight.ArrivalCity}. To : {flight.DepartureCity}.\n" +
                    $"Date : {flight.ArrivalTime}\n" +
                    $"Id : {flight.AirplaneId}\n" +
                    $"Name Airplane : {flight.Airplane?.Model}\n" +
                    $"Max passangers : {flight.Airplane.MaxCountPassengers}\n");
            }

            var client = dbContext.Clients.Find(1);
            dbContext?.Entry(client).Collection(c => c.Flights).Load();
            Console.WriteLine($"Name :: {client?.Name} . Rating :: {client.Rating}");
            Console.WriteLine($"All flights :: {client?.Flights.Count}");
            foreach (var f in client?.Flights)
            {
                Console.WriteLine($"From :: {f.ArrivalCity} to {f.DepartureCity}\n" +
                    $"Date :: {f.ArrivalTime}");
            }
        }
    }
}
