using Microsoft.EntityFrameworkCore;
using intro_to_entity_framework.Models;
using intro_to_entity_framework.Helpers;
using _06_dataAccessAirport2.Models;

namespace intro_to_entity_framework
{
    public class AirportDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<AirplaneType> AirplaneTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public AirportDbContext()
        {
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
        }

        //connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AirportDb;Integrated Security=True;Connect Timeout=5;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=5");
        }
        //work with database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //validation data - fluent api 

            modelBuilder.Entity<Airplane>().
                Property(a => a.Model).
                IsRequired().
                HasMaxLength(100);


            modelBuilder.Entity<Client>().
                ToTable("Passangers");
            modelBuilder.Entity<Client>().
                Property(c => c.Name).
                IsRequired().
                HasMaxLength(100).
                HasColumnName("Firstname");
            modelBuilder.Entity<Client>().
                Property(c => c.Email).
                HasMaxLength(100).
                IsRequired();


            modelBuilder.Entity<Flight>().
                HasKey(f => f.Number);
            modelBuilder.Entity<Flight>().
                Property(f => f.ArrivalCity).
                HasMaxLength(100);
            modelBuilder.Entity<Flight>().
                Property(f => f.DepartureCity).
                HasMaxLength(100);


            modelBuilder.Entity<Flight>().
                HasOne(f => f.Airplane).
                WithMany(a => a.Flights).
                HasForeignKey(f => f.AirplaneId);


            modelBuilder.Entity<Client>().
                HasMany(c => c.Flights).
                WithMany(f => f.Clients);

            modelBuilder.Entity<AirplaneType>().
                Property(at => at.TYPE).
                HasMaxLength(100);
            modelBuilder.Entity<AirplaneType>().
                HasMany(at => at.Airplanes).
                WithOne(a => a.AirplaneType);

            modelBuilder.Entity<Country>().
                Property(co => co.NAME).
                HasMaxLength(100).
                IsRequired();
            modelBuilder.Entity<Country>().
                HasMany(co => co.Cities).
                WithOne(ci => ci.Country).
                HasForeignKey(ci => ci.CountryID);

            modelBuilder.Entity<City>().
                Property(ci => ci.NAME).
                IsRequired().
                HasMaxLength(100);
            modelBuilder.Entity<City>().
                HasMany(ci => ci.Flights).
                WithOne(f => f.City);



            //Initialization
            modelBuilder.SeedAirplanes();
            modelBuilder.SeedClients();
            modelBuilder.SeedFlights();
            modelBuilder.SeedAirplaneType();
            modelBuilder.SeedCountry();
            modelBuilder.SeedCity();
            
        }
    }
}
