namespace RideAlong.Models.Domain {
    public class Driver : Person {



        private int _aantalPassagiers;
        public int AantalPassagiers {
            get {
                return _aantalPassagiers;
            }
            private set {
                if (value >= 0) {
                    _aantalPassagiers = value;
                }
            }
        }

        private float _rating;
        public float Rating {
            get {
                return _rating;
            }
            private set {
                if(value >= 0) {
                    _rating = value;
                }
            } 
        }

        private float _maxDetour;
        public float MaxDetour {
            get {
                return _maxDetour;
            }
            private set {
                if (value >= 0) {
                    _maxDetour = value;
                }
            }
        }


        public Driver(string voornaam, string naam, string telefoonnr, int aantalPassagiers, float rating, float maxDetour) : base(voornaam, naam, telefoonnr) {
            AantalPassagiers = aantalPassagiers;
            Rating = rating;
            MaxDetour = maxDetour;
        }
    }
}
