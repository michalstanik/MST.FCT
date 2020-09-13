using Microsoft.EntityFrameworkCore;
using MST.IDP.Domain;
using MST.IDP.Shared.Interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MST.IDP.Data
{
    public class IdentityDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserClaim> UserClaim { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Subject)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>().HasData(
               new User()
               {
                   Id = new Guid("A98AAB29-5807-4487-94F8-08D857FDD95F"),
                   Password = "AQAAAAEAACcQAAAAELh/TFL1qtIL9+07j1JbNPk7VMrJQ07QMCQD6OdJxvl0l+lXaljbphhlZcfrlNM44w==",
                   Subject = "2b6803d7-3983-4aae-a0c3-0feb52f699b6",
                   Email = "michal@gmail.com",
                   Username = "Michal",
                   Active = true
               });

            modelBuilder.Entity<UserClaim>().HasData(
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("A98AAB29-5807-4487-94F8-08D857FDD95F"),
                 Type = "given_name",
                 Value = "Michal"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("A98AAB29-5807-4487-94F8-08D857FDD95F"),
                 Type = "family_name",
                 Value = "Stanik"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("A98AAB29-5807-4487-94F8-08D857FDD95F"),
                 Type = "country",
                 Value = "pl"
             });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var updatedConcurencyAwareEntries = ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Modified)
                    .OfType<IConcurrencyAware>();

            foreach (var entry in updatedConcurencyAwareEntries)
            {
                entry.ConcurrencyStamp = Guid.NewGuid().ToString();
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
