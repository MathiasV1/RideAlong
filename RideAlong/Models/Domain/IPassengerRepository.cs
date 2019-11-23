using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public interface IPassengerRepository
    {
        
        IEnumerable<Passenger> GetAll();
        void Add(Passenger passenger);
        void Delete(Passenger passenger);
        Passenger GetBy(int index);
        List<Passenger> getAllInRange(Location startLocDriver, float maxDetour);
    }
}
