using Microsoft.EntityFrameworkCore;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RideAlong.Data.Repositories {
    public class DriverRepository : IDriverRepository {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Driver> _drivers;

        public DriverRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
            _drivers = dbContext.Drivers;
        }

        public void Add(Driver driver) {
            _drivers.Add(driver);
        }

        public void Delete(Driver driver) {
            _drivers.Remove(driver);
        }

        public IEnumerable<Driver> GetAll() {
            return _drivers;
        }

        public Driver GetBy(int driverId) {
            return _drivers.Include(b => b).SingleOrDefault(b => b.ID == driverId);
        }

        public void SaveChanges() {
            _dbContext.SaveChanges();
        }
    }
}
