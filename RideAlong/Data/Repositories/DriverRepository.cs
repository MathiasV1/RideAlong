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
        IList<Person> _drivers;
        PersonMapper _pm;

        public DriverRepository()
        {
            _pm = new PersonMapper();
            _drivers = _pm.GetPersons();
        }

        public void Add(Driver driver)
        {
            throw new NotImplementedException();
        }

        public void Delete(Driver driver)
        {
            throw new NotImplementedException();
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
