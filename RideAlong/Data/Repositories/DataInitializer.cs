using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Repositories
{
    public class DataInitializer
    {
        public IList<Passenger> Passengers { get { return _passengers; } }
        public IList<Driver> Drivers { get { return _drivers; } }
        private IList<Driver> _drivers;
        private IList<Passenger> _passengers;

        public DataInitializer()
        {
            _drivers = GetDrivers();
            _passengers = GetPassengers();
        }

        private IList<Passenger> GetPassengers()
        {
            IList<Passenger> passengers = new List<Passenger> {
            new Passenger("Erik", "Erikson", "049357890", true),
            new Passenger("Peter", "Petersen", "0493678901", false),
            new Passenger("Tom", "Aat", "0493789012", true),
            new Passenger("Peter", "Selie", "0493890123", true)

        };
            return passengers;
        }

        public IList<Driver> GetDrivers()
        {
            IList<Driver> drivers = new List<Driver>
            {
                new Driver("Jan", "Janssen", "0494123456", 4, 4, 10),
            new Driver("Piet", "Pieters", "0494234567", 2, 3, 5),
            new Driver("Joris", "Jorissen", "0494345678", 4, 5, 15),
            new Driver("Corneel", "Cornelis", "0494456789", 3, 4, 10)
        };
            return drivers;
        }

    }
}
