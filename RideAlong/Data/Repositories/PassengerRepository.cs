using Microsoft.EntityFrameworkCore;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RideAlong.Data.Repositories {
    public class PassengerRepository : IPassengerRepository {
        private readonly DataInitializer di;
        private IList<Passenger> _passengers;
        private IList<Driver> _drivers;

        public PassengerRepository() {
            di = new DataInitializer();
            _passengers = di.Passengers;
            
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

        public Passenger GetBy(int index)
        {
            return _passengers.ElementAt(index);
        }
    }
}
