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
                   Id = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                   Password = "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==",
                   Subject = "d860efca-22d9-47fd-8249-791ba61b07c7",
                   Email = "frank@gmail.com",
                   Username = "Frank",
                   Active = true
               },
               new User()
               {
                   Id = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                   Password = "AQAAAAEAACcQAAAAEAAP1QAc8J6Ri88b4+01i2M+u9amqIhA8Jo1pvdIWTO0Le3NPqPAyQzrbWYQHSD0WA==",
                   Subject = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                   Email = "claire@gmail.com",
                   Username = "Claire",
                   Active = true
               });

            modelBuilder.Entity<UserClaim>().HasData(
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                 Type = "given_name",
                 Value = "Frank"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                 Type = "family_name",
                 Value = "Underwood"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                 Type = "address",
                 Value = "Main Road 1"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                 Type = "subscriptionlevel",
                 Value = "FreeUser"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                 Type = "country",
                 Value = "nl"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                 Type = "given_name",
                 Value = "Claire"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                 Type = "family_name",
                 Value = "Underwood"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                 Type = "address",
                 Value = "Big Street 2"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                 Type = "subscriptionlevel",
                 Value = "PayingUser"
             },
             new UserClaim()
             {
                 Id = Guid.NewGuid(),
                 UserId = new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                 Type = "country",
                 Value = "be"
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
