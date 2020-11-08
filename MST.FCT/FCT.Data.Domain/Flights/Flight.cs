﻿using FCT.Data.Domain.Aviation;
using FCT.Data.Domain.User;
using System;
using System.Collections.Generic;

namespace FCT.Data.Domain.Flights
{
    public class Flight
    {
        public Flight()
        {
            UserFlights = new List<UserFlight>();
        }
        public int Id { get; set; }
        public string FlightNumber { get; set; }

        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivialDate { get; set; }

        public DateTime? ScheduleDepartureDate { get; set; }
        public DateTime? ScheduleArrivialDate { get; set; }

        public Airport DepartureAirport { get; set; }
        public Airport ArrivalAirport { get; set; }

        //public int? CombinedPreviousFlightId { get; set; }
        //public Flight CombinedPreviousFlight { get; set; }

        //public int? CombinedNextFlightId { get; set; }
        //public Flight CombinedNextFlight { get; set; }

        public long? Distance { get; set; }

        public int? AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }

        //TODO: When Trips will be avaliable
        //public int? TripId { get; set; }
        //public Trip Trip { get; set; }

        public int? AirlineId { get; set; }
        public Airline Airline { get; set; }

        public FlightType FlightTypeAssessment { get; set; }
        public FlightPurpose FlightPurposeAssessment { get; set; }

        public enum FlightType
        {
            Charter,
            Scheduled
        }

        public enum FlightPurpose
        {
            Business, 
            Private
        }

        public List<UserFlight> UserFlights { get; set; }

        public IEnumerable<TUser> Users()
        {
            var users = new List<TUser>();
            foreach (var join in UserFlights)
            {
                users.Add(join.TUser);
            }
            return users;
        }
    }
}
