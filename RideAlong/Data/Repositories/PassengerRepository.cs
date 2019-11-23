using Microsoft.EntityFrameworkCore;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RideAlong.Data.Repositories {
    public class PassengerRepository : IPassengerRepository {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Passenger> _passengers;

        public PassengerRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
            _passengers = dbContext.Passengers;
        }

        public void Add(Passenger passenger) {
            _passengers.Add(passenger);
        }

        public void Delete(Passenger passenger) {
            _passengers.Remove(passenger);
        }

        public IEnumerable<Passenger> GetAll() {
            return _passengers;
        }

        public List<Passenger> getAllInRange(Location startLocDriver, float maxDetour) {
            return _passengers.Where(b => b.StartLocation.getLocValue() < startLocDriver.getLocValue() + maxDetour).ToList();
        }

        public Passenger GetBy(int passengerId) {
            return _passengers.Include(b => b).SingleOrDefault(b => b.ID == passengerId);
        }

        public void SaveChanges() {
            _dbContext.SaveChanges();
        }
    }
}
