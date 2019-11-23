using RideAlong.Models.Persistentie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public class PersonRepository
    {
        IList<Person> _persons;
        PersonMapper _pm;

        public PersonRepository()
        {
            _pm = new PersonMapper();
            _persons = _pm.GetPersons();
        }
    }
}
