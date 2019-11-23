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
        private Location _startlocation;
        private Location _endlocation;

        public string Voornaam
        {
            get
            {
                return _voornaam;
            }
            set
            {
                if (value != null && !value.Equals(""))
                {
                    _voornaam = value;
                }
            }
        }
        public string Naam
        {
            get
            {
                return _naam;
            }
            set
            {
                if (value != null && !value.Equals(""))
                {
                    _naam = value;
                }
            }
        }
        public string TelefoonNummer
        {
            get
            {
                return _telefoonnummer;
            }
            set
            {
                if (value != null && !value.Equals(""))
                {
                    _telefoonnummer = value;
                }
            }
        }
        public Location StartLocation
        {
            get { return _startlocation; }
            set
            {
                if (value != null)
                {
                    _startlocation = value;
                }
            }
        }
        public Location EndLocation
        {
            get { return _endlocation; }
            set
            {
                if (value != null)
                {
                    _endlocation = value;
                }
            }
        }

        public Person(string voornaam, string naam, string telefoonNummer)
        {
            Voornaam = voornaam;
            Naam = naam;
            TelefoonNummer = telefoonNummer;
        }


    }
}
