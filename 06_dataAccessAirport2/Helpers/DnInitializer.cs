using _06_dataAccessAirport2.Models;
using intro_to_entity_framework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace intro_to_entity_framework.Helpers
{
    internal static class DnInitializer
    {
        public static void SeedAirplanes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airplane>().HasData(new Airplane[]
            {
                new Airplane(){ Id = 1, Model = "AN747", AirplaneTypeID = 1 },
                new Airplane(){ Id = 2, Model = "AN746", AirplaneTypeID = 1 },
                new Airplane(){ Id = 3, Model = "AN746", AirplaneTypeID = 1 },
                new Airplane(){ Id = 4, Model = "AN744", AirplaneTypeID = 2 },
                new Airplane(){ Id = 5, Model = "AN743", AirplaneTypeID = 1 },
            });
        }

        public static void SeedClients(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(new Client[]
           {
               new Client(){ Id = 1,Name = "Vova", Email = "vova@gmail.com", Birthdate = new DateTime(1995,5,14) },
               new Client(){ Id = 2,Name = "Ira", Email = "ira@gmail.com", Birthdate = new DateTime(2000,5,14) },
               new Client(){ Id = 3,Name = "Nikita", Email = "nikita@gmail.com", Birthdate = new DateTime(2001,5,14) },
               new Client(){ Id = 4,Name = "Sasha", Email = "sasha@gmail.com", Birthdate = new DateTime(2003,5,14) },
               new Client(){ Id = 5,Name = "Dima", Email = "dima@gmail.com", Birthdate = new DateTime(2005,5,14) }
           });
        }

        public static void SeedFlights(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasData(new Flight[]
          {
               new Flight(){ Number = 1, ArrivalCity= "Kyiv", DepartureCity= "Lviv", ArrivalTime = new DateTime(2026,3,10),
               DepartureTime =new DateTime(2026,3,10), AirplaneId = 1, CityID = 2},
                new Flight(){ Number = 2, ArrivalCity= "Kyiv", DepartureCity= "Praga", ArrivalTime = new DateTime(2026,3,10),
               DepartureTime =new DateTime(2026,3,10), AirplaneId = 1, CityID = 2 },
                 new Flight(){ Number = 3, ArrivalCity= "Kyiv", DepartureCity= "Warshaw", ArrivalTime = new DateTime(2026,3,10),
               DepartureTime =new DateTime(2026,3,10), AirplaneId = 1, CityID = 2 },
                  new Flight(){ Number = 4, ArrivalCity= "Kyiv", DepartureCity= "Kharkiv", ArrivalTime = new DateTime(2026,3,10),
               DepartureTime =new DateTime(2026,3,10), AirplaneId = 1, CityID = 2 },

          });
        }

        public static void SeedCountry(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Country>().HasData(new Country[]
            {
                new Country(){ ID = 1, NAME = "Ukraine" },
                new Country(){ ID = 2, NAME = "Poland" },
                new Country(){ ID = 3, NAME = "Germany" }
            });
        }

        public static void SeedCity(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<City>().HasData(new City[]
            {
                new City(){ ID = 1, NAME = "Kyiv", CountryID = 1},
                new City(){ ID = 2, NAME = "Lviv", CountryID = 1},
                new City(){ ID = 3, NAME = "Uzhorod", CountryID = 1}
            });
        }

        public static void SeedAirplaneType(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<AirplaneType>().HasData(new AirplaneType[]
            {
                new AirplaneType(){ ID = 1, TYPE = "Passanger plane", AirplaneID = 1},
                new AirplaneType(){ ID = 2, TYPE = "Cargo", AirplaneID = 2}
            });
        }
    }
}
