using FCT.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FCT.Data.Repositories
{
    public class StatsRepository : IStatsRepository
    {
        private readonly FCTContext _context;

        public StatsRepository(FCTContext context)
        {
            _context = context;
        }

        public int GetAirportsCountForUser(string userId)
        {
            var departureAirports = _context.UserFlight.Where(u => u.TUserId == userId)
                 .Select(t => t.Flight)
                 .Select(t => t.DepartureAirport.ICAO).Distinct().ToList();

            var arrivalAirports = _context.UserFlight.Where(u => u.TUserId == userId)
                .Select(t => t.Flight)
                .Select(t => t.ArrivalAirport.ICAO).Distinct().ToList();

            departureAirports.AddRange(arrivalAirports);

            return departureAirports.Distinct().Count();
        }

        public int GetFlightsCountForUser(string userId)
        {
            return _context.UserFlight.Where(u => u.TUserId == userId).Select(t => t.Flight).Distinct().Count();
        }

        public long GetFlightsDistanceForUser(string userId)
        {
            return (long)_context.UserFlight.Where(u => u.TUserId == userId).Select(t => t.Flight).Select(f => f.Distance).Sum();
        }

        public long GetFlightsTimeForUser(string userId)
        {
            var userFlights = _context.UserFlight.Where(u => u.TUserId == userId).Select(t => t.Flight).ToList();

            long totalTime = 0;
            foreach (var flightTime in from flight in userFlights
                                       let flightTime = flight.ArrivialDate - flight.DepartureDate
                                       select flightTime)
            {
                totalTime += flightTime.GetValueOrDefault().Hours;
            }

            return totalTime;
        }

        public TimeSpan GetFlightsTimeSpanForUser(string userId)
        {
            var userFlights = _context.UserFlight.Where(u => u.TUserId == userId).Select(t => t.Flight).ToList();

            TimeSpan totalTime;

            foreach (var flight in userFlights)
            {
                var flightTime = flight.ArrivialDate - flight.DepartureDate;
                totalTime += (TimeSpan)flightTime;
            }
            return totalTime;
        }
    }
}
