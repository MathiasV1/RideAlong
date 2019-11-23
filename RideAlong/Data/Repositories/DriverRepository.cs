using RideAlong.Models.Domain;
using RideAlong.Models.Persistentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Repositories
{
    public class DriverRepository: IDriverRepository
    {
        //private readonly ApplicationDbContext _dbContext;
        //private readonly DBSet<Person> _drivers;
        PersonMapper _pm;

        public DriverRepository()
        {
            //_dbContext = dbContext;
            //_brewers = dbContext.Brewers;
        }

        public void Add(Driver driver)
        {
            //_drivers.add(driver);
        }

        public void Delete(Driver driver)
        {
            //_drivers.remove(driver);
        }

        public IEnumerable<Driver> GetAll()
        {
            throw new NotImplementedException();
        }

        public Driver GetBy(int driverId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
