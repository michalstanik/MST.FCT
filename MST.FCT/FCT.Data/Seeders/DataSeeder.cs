using FCT.Data.Domain.Aviation;
using FCT.Data.Domain.Flights;
using FCT.Data.Domain.Geo;
using FCT.Data.Domain.User;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FCT.Data.Seeders
{
    public class DataSeeder
    {
        private readonly FCTContext _context;
        private readonly ILogger<DataSeeder> _logger;
        private List<AircraftModel> _createdAircraftModels;
        private List<AircraftFactory> _createdAircraftFactories;
        private List<Country> _createdCountries;
        private List<Airport> _createdAirports;
        private List<AirlineAlliance> _createdAirlineAlliances;
        private List<Airline> _createdAirlines;
        private List<Aircraft> _createdAircrafts;
        private List<Flight> _createdFlights;
        private List<TUser> _createdUsers;

        public DataSeeder(FCTContext context, ILogger<DataSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Seed()
        {
            if (_context.Flight.Any()) return;

            //Dictonaries
            _createdCountries = _context.Country.ToList();
            _createdAirports = _context.Airport.ToList();

            //Created in DataSeeder
            _logger.LogInformation("DB Seeder: Users");
            _createdUsers = CreateUsers();
            
            _logger.LogInformation("DB Seeder: Airline Alliances");
            _createdAirlineAlliances = CreateAirlineAlliance();
            
            _logger.LogInformation("DB Seeder: Airlines");
            _createdAirlines = CreateAirlines();
            
            _logger.LogInformation("DB Seeder: Aircraft Factories");
            _createdAircraftFactories = CreateAircraftFactories();
            
            _logger.LogInformation("DB Seeder: Aircraft Models");
            _createdAircraftModels = CreateAircraftModel();
            
            _logger.LogInformation("DB Seeder: Aircrafts");
            _createdAircrafts = CreateAircrafts();
            
            _logger.LogInformation("DB Seeder: Fligts");
            _createdFlights = CreateFlights();
        }

        private List<Flight> CreateFlights()
        {
            var flights = new List<Flight>()
            {
                new Flight()
                {
                    FlightNumber = "P7 1754",
                    Aircraft = null,
                    Airline = GetAirline("LLC"),
                    DepartureAirport = GetAirport("WAW"),
                    DepartureDate = new DateTime(2015,8,29,3,0,0),
                    ScheduleDepartureDate = new DateTime(2015,8,29,3,0,0),
                    ArrivalAirport = GetAirport("KGS"),
                    ArrivialDate = new DateTime(2015,8,29,6,0,0),
                    ScheduleArrivialDate = new DateTime(2015,8,29,6,0,0),
                    Distance = 1775,
                    FlightTypeAssessment = Flight.FlightType.Charter,
                    FlightPurposeAssessment = Flight.FlightPurpose.Private,
                    UserFlights = new List<UserFlight>()
                    {
                        new UserFlight() { TUser = GetUser("Michal") }
                    }
                },
                new Flight()
                {
                    FlightNumber = "P7 1755",
                    Aircraft = null,
                    Airline = GetAirline("LLC"),
                    DepartureAirport = GetAirport("KGS"),
                    DepartureDate = new DateTime(2015,9,05,10,0,0),
                    ScheduleDepartureDate = new DateTime(2015,9,05,10,0,0),
                    ArrivalAirport = GetAirport("WAW"),
                    ArrivialDate = new DateTime(2015,9,05,12,0,0),
                    ScheduleArrivialDate = new DateTime(2015,9,05,12,0,0),
                    Distance = 1775,
                    FlightTypeAssessment = Flight.FlightType.Charter,
                    FlightPurposeAssessment = Flight.FlightPurpose.Private,
                    UserFlights = new List<UserFlight>()
                    {
                        new UserFlight() { TUser = GetUser("Michal") }
                    }
                },
                new Flight()
                {
                    FlightNumber = "W6 1441",
                    Aircraft = null,
                    Airline = GetAirline("WZZ"),
                    DepartureAirport = GetAirport("WAW"),
                    DepartureDate = new DateTime(2016,9,22,12,20,0),
                    ScheduleDepartureDate = new DateTime(2016,9,22,12,20,0),
                    ArrivalAirport = GetAirport("FCO"),
                    ArrivialDate = new DateTime(2016,9,22,14,45,0),
                    ScheduleArrivialDate = new DateTime(2016,9,22,14,45,0),
                    Distance = 1327,
                    FlightTypeAssessment = Flight.FlightType.Scheduled,
                    FlightPurposeAssessment = Flight.FlightPurpose.Private,
                    UserFlights = new List<UserFlight>()
                    {
                        new UserFlight() { TUser = GetUser("Michal") }
                    }
                }
            };

            _context.AddRange(flights);
            _context.SaveChanges();

            return flights;
        }

        private List<Aircraft> CreateAircrafts()
        {
            return new List<Aircraft>();
        }

        private List<TUser> CreateUsers()
        {
            var users = new List<TUser>()
            {
                new TUser() { Id = "2b6803d7-3983-4aae-a0c3-0feb52f699b6", UserName = "Michal" },
            };

            _context.AddRange(users);
            _context.SaveChanges();

            return users;
        }

        private List<AirlineAlliance> CreateAirlineAlliance()
        {
            var airlineAlliences = new List<AirlineAlliance>()
            {
                new AirlineAlliance() { Name = "SkyTeam"},
                new AirlineAlliance() { Name = "Star Alliance"}
            };

            _context.AddRange(airlineAlliences);
            _context.SaveChanges();

            return airlineAlliences;
        }

        private List<Airline> CreateAirlines()
        {
            var airlines = new List<Airline>()
            {
                new Airline() {Name = "WizzAir", AirlineCountry = GetCountry("HUN"), IATA = "W6", ICAO = "WZZ"},
                new Airline() {Name = "Enter Air", AirlineCountry = GetCountry("POL"), IATA = "E4", ICAO = "ENT" },
                new Airline() {Name = "Ryanair", AirlineCountry = GetCountry("IRL"), IATA = "FR", ICAO = "RYR" },
                new Airline() {Name = "Emirates", AirlineCountry = GetCountry("ARE"), IATA = "EK", ICAO = "UAE"},
                new Airline() {Name = "Travel Service Poland", AirlineCountry = GetCountry("POL"), IATA = "3Z", ICAO = "TVP"},
                new Airline() {Name = "Small Planet", AirlineCountry = GetCountry("LTU"), IATA = "S5", ICAO = "LLC"},
                new Airline() {Name = "Binter", AirlineCountry = GetCountry("ESP"), IATA = "NT", ICAO = "IBB"},
                new Airline() {Name = "Volaris", AirlineCountry = GetCountry("MEX"), IATA = "Y4", ICAO = "VOI"},
                new Airline() {Name = "Air France", AirlineCountry = GetCountry("FRA"),IATA = "AF", ICAO = "AFR", AirLineAlliance = GetAirlineAlliance("SkyTeam")},
                new Airline() {Name = "KLM", AirlineCountry = GetCountry("NLD"), IATA = "KL", ICAO = "KLM", AirLineAlliance = GetAirlineAlliance("SkyTeam")},
                new Airline() {Name = "LOT", AirlineCountry = GetCountry("POL"), IATA = "LO", ICAO = "LOT", AirLineAlliance = GetAirlineAlliance("Star Alliance")},
                new Airline() {Name = "Turkish Airlines", AirlineCountry = GetCountry("TUR"), IATA = "TK", ICAO = "THY", AirLineAlliance = GetAirlineAlliance("Star Alliance")},
            };

            _context.AddRange(airlines);
            _context.SaveChanges();

            return airlines;
        }

        private List<AircraftFactory> CreateAircraftFactories()
        {
            var aircraftFactories = new List<AircraftFactory>()
            {
                new AircraftFactory() {  Name = "Boeing", AircraftFactoryCountry = GetCountry("USA") },
                new AircraftFactory() { Name = "Airbus", AircraftFactoryCountry = GetCountry("FRA") },
                new AircraftFactory() { Name = "Embraer", AircraftFactoryCountry = GetCountry("BRA") },
                new AircraftFactory() { Name = "ATR", AircraftFactoryCountry = GetCountry("FRA") }
            };

            _context.AddRange(aircraftFactories);
            _context.SaveChanges();

            return aircraftFactories;
        }

        private List<AircraftModel> CreateAircraftModel()
        {
            AircraftFactory boeing = GetAircrafFactory("Boeing");
            AircraftFactory atr = GetAircrafFactory("ATR");
            AircraftFactory airbus = GetAircrafFactory("Airbus");
            AircraftFactory embraer = GetAircrafFactory("Embraer");

            var aircraftModels = new List<AircraftModel>()
            {
                new AircraftModel() { AircraftFactory = boeing, Model = "737-700" },
                new AircraftModel() { AircraftFactory = boeing, Model = "737-800" },
                new AircraftModel() { AircraftFactory = boeing, Model = "737 MAX 8" },
                new AircraftModel() { AircraftFactory = boeing, Model = "777-300ER" },
                new AircraftModel() { AircraftFactory = boeing, Model = "787-8" },
                new AircraftModel() { AircraftFactory = boeing, Model = "787-9" },

                new AircraftModel() { AircraftFactory = atr, Model = "72" },

                new AircraftModel() { AircraftFactory = airbus, Model = "A318" },
                new AircraftModel() { AircraftFactory = airbus, Model = "A320" },
                new AircraftModel() { AircraftFactory = airbus, Model = "A321" },
                new AircraftModel() { AircraftFactory = airbus, Model = "A330-200" },
                new AircraftModel() { AircraftFactory = airbus, Model = "A380-800" },

                new AircraftModel() { AircraftFactory = embraer, Model = "190" }
            };

            _context.AddRange(aircraftModels);
            _context.SaveChanges();

            return aircraftModels;
        }

        private TUser GetUser(string name)
        {
            return _createdUsers.Where(u => u.UserName == name).FirstOrDefault();
        }

        private Airport GetAirport(string iataCode)
        {
            return _createdAirports.Where(a => a.IATA == iataCode).FirstOrDefault();
        }

        private Aircraft GetAircraft(string tailNumber)
        {
            return _createdAircrafts.Where(a => a.TailNumber == tailNumber).FirstOrDefault();
        }

        private Airline GetAirline(string icaoCode)
        {
            return _createdAirlines.Where(a => a.ICAO == icaoCode).FirstOrDefault();
        }

        private AircraftModel GetAircraftModel(string model)
        {
            return _createdAircraftModels.Where(m => m.Model == model).FirstOrDefault();
        }

        private Country GetCountry(string alpha3Code)
        {
            return _createdCountries.Where(c => c.Alpha3Code == alpha3Code).FirstOrDefault();
        }

        private AircraftFactory GetAircrafFactory(string name)
        {
            return _createdAircraftFactories.Where(m => m.Name == name).FirstOrDefault();
        }

        private AirlineAlliance GetAirlineAlliance(string name)
        {
            return _createdAirlineAlliances.Where(a => a.Name == name).FirstOrDefault();
        }
    }
}
