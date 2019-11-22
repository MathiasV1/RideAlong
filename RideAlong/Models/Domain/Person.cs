using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAlong.Models.Domain
{
    public class Person
    {
        private string _voornaam;
        private string _naam;
        private string _telefoonnummer;

        public Person(string voornaam, string naam, string telefoonNummer)
        {
            _voornaam = voornaam;
            _naam = naam;
            _telefoonnummer = telefoonNummer;
        }
    }
}
