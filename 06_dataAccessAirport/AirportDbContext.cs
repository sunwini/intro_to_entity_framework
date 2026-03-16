using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using intro_to_entity_framework.Models;
using intro_to_entity_framework.Helpers;

namespace intro_to_entity_framework
{
    internal class AirportDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
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




            //Initialization
            modelBuilder.SeedAirplanes();
            modelBuilder.SeedClients();
            modelBuilder.SeedFlights();
            
            
        }
    }
}
