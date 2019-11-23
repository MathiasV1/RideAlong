using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    interface IPassengerRepository
    {
        Passenger GetBy(int passengerId);
        IEnumerable<Passenger> GetAllInRange(float maxDetour);
        IEnumerable<Passenger> GetAll();
        void Add(Passenger passenger);
        void Delete(Passenger passenger);
        void SaveChanges();
    }
}
