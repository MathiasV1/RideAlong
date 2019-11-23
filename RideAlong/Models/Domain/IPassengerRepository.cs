using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public interface IPassengerRepository
    {
        Passenger GetBy(int passengerId);
        IEnumerable<Passenger> GetAll();
        void Add(Passenger passenger);
        void Delete(Passenger passenger);
        void SaveChanges();
        List<Passenger> getAllInRange(Location startLocDriver, float maxDetour);
    }
}
