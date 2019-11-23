using Microsoft.EntityFrameworkCore;
using RideAlong.Models.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Repositories
{
    public class PassengerRepository: IPassengerRepository
    {

        private readonly DbSet<Driver> _drivers;
        private readonly DbSet<Passenger> _passengers;
        private readonly ApplicationDbContext _dbContext;

        public PassengerRepository(ApplicationDbContext adbc)
        {
            _dbContext = adbc;
            _passengers = adbc.Passengers;
            _drivers = adbc.Drivers;
            
        }

        public void Add(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public void Delete(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passenger> GetAll()
        {
            throw new NotImplementedException();
        }

        public Passenger GetBy(int passengerId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
