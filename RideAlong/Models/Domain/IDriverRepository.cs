using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public interface IDriverRepository
    {
        
        IEnumerable<Driver> GetAll();
        void Add(Driver driver);
        void Delete(Driver driver);
        Driver GetBy(int index);
    }
}
