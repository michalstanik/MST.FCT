using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FCT.Data.Seeders
{
    public class EnsureDB
    {
        private readonly FCTContext _context;

        public EnsureDB(FCTContext context) => _context = context;

        public void EnsureMigrated()
        {
            _context.Database.Migrate();
        }

        public void EnsureDeletedAndRecreated()
        {
            _context.Database.EnsureDeleted();
            _context.Database.Migrate();
        }

        public void EnsureCreatedAndMigrated()
        {
            _context.Database.EnsureCreated();
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
