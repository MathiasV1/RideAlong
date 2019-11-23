namespace RideAlong.Models.Domain {
    public class Location {
        private int locValue;

        public Location(int locValue) {
            if(locValue >= 0) {
                this.locValue = locValue;
            }
        }

        public int getLocValue() {
            return this.locValue;
        }
    }
}
