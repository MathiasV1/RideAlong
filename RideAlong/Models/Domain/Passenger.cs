using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public class Passenger : Person
    {
        public bool Subscription { get; private set; }

        public Passenger(string voornaam, string naam, string telefoonnummer, bool subscription): base(voornaam, naam, telefoonnummer) 
        {
            Subscription = subscription;             
        }
    }
}
