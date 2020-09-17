﻿using FCT.Data.Domain.Aviation;
using FCT.Data.Domain.Flights;
using Microsoft.EntityFrameworkCore;

namespace FCT.Data
{
    public class FCTContext : DbContext
    {
        public FCTContext(DbContextOptions<FCTContext> options) : base(options)
        {

        }

        //Aviation
        public DbSet<Airport> Airport { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<AircraftFactory> AircraftFactory { get; set; }
        public DbSet<AircraftModel> AircraftModel { get; set; }
        public DbSet<Airline> Airline { get; set; }
        public DbSet<AirlineAlliance> AirLineAlliance { get; set; }

        //Flights
        public DbSet<Flight> Flight { get; set; }

        //Admin

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Flight
            modelBuilder.Entity<Flight>().Property(f => f.FlightTypeAssessment).HasConversion<string>();
        }
    }
}