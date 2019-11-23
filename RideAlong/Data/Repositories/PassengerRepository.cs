using RideAlong.Models.Domain;
using RideAlong.Models.Persistentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Data.Repositories
{
    public class PassengerRepository: IPassengerRepository
    {
        IList<Person> _passengers;
        PersonMapper _pm;

        public PassengerRepository()
        {
            _pm = new PersonMapper();
            _passengers = _pm.GetPersons();
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
