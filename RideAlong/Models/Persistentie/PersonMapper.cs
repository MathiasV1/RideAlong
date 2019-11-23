using RideAlong.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Persistentie
{
    public class PersonMapper
    {
        private IList<Person> _persons;

        public PersonMapper()
        {

        }

        public IList<Person> GetPersons()
        {
            return _persons;
        }
    }
}
