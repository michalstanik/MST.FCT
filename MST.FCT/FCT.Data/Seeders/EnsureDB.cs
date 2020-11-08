using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace FCT.Data.Seeders
{
    public class EnsureDB
    {
        private readonly FCTContext _context;
        private readonly ILogger<EnsureDB> _logger;

        public EnsureDB(FCTContext context, ILogger<EnsureDB> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void EnsureMigrated()
        {
            _logger.LogInformation("Migrate Database started");
            var migrations = _context.Database.GetAppliedMigrations();
            foreach (var item in migrations)
            {
                _logger.LogInformation($"Applying Migration: {item}");
            }
            _context.Database.Migrate();
        }

        public void EnsureDeletedAndRecreated()
        {
            _logger.LogInformation("DROP Database started");
            _context.Database.EnsureDeleted();
            _logger.LogInformation("CREATE Database started");
            _context.Database.Migrate();
        }

        public void EnsureCreatedAndMigrated()
        {
            _logger.LogInformation("CREATE Database started");
            _context.Database.EnsureCreated();
            _logger.LogInformation("Migrate Database started");
            _context.Database.Migrate();
        }
        public void RemoveLogsOlderThan(double hours)
        {
            var logstoberemoved = _context.Log.Where(l => l.TimeStamp <= DateTimeOffset.Now.AddHours(-hours)).ToList();
            _context.Log.RemoveRange(logstoberemoved);
            _context.SaveChanges();
        }
    }
}
