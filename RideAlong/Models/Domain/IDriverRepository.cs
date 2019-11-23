using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public interface IDriverRepository
    {
        Driver GetBy(int driverId);
        IEnumerable<Driver> GetAll();
        void Add(Driver driver);
        void Delete(Driver driver);
        void SaveChanges();
    }
}
