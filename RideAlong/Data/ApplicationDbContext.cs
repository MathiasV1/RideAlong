using Microsoft.EntityFrameworkCore;
using RideAlong.Data.Mappers;
using RideAlong.Models.Domain;

namespace RideAlong {
    public class ApplicationDbContext : DbContext {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = @"Server=.;Database=DbRideAlong;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DriverConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
        }
    }
}