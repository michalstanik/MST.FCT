using FCT.Data.Domain.Admin;
using FCT.Data.Domain.Aviation;
using FCT.Data.Domain.Flights;
using FCT.Data.Domain.Geo;
using FCT.Data.Domain.User;
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
        public DbSet<Log> Log { get; set; }

        //Geo
        public DbSet<Continent> Continent { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<TimeZone> TimeZone { get; set;}

        //User
        public DbSet<TUser> TUser { get; set; }
        public DbSet<UserFlight> UserFlight { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Flight
            modelBuilder.Entity<Flight>().Property(f => f.FlightTypeAssessment).HasConversion<string>();

            //UserFLigts
            modelBuilder.Entity<UserFlight>().HasKey(uf => new { uf.FlightId, uf.TUserId });
        }
    }
}
