﻿using System;

namespace FCT.Data.IRepositories
{
    public interface IStatsRepository
    {
        int GetFlightsCountForUser(string userId);
        int GetAirportsCountForUser(string userId);
        int GetAirportsCountryCountForUser(string userId);
        long GetFlightsDistanceForUser(string userId);
        long GetFlightsTimeForUser(string userId);
        TimeSpan GetFlightsTimeSpanForUser(string userId);
    }
}
