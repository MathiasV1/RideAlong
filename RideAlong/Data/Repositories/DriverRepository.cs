using Microsoft.EntityFrameworkCore;
using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RideAlong.Data.Repositories {
    public class DriverRepository : IDriverRepository {
        private readonly DataInitializer _di;
        private IList<Driver> _drivers;

        public DriverRepository() {
            _di = new DataInitializer();
            _drivers = _di.Drivers;
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

        public Driver GetBy(int index)
        {
            return _drivers.ElementAt(index);
        }
    }
}
