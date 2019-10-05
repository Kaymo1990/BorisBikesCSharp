namespace BorisBikes
{
    public class Bike {
        public bool bikeStatus = true;
        public bool IsWorking()
        {
            return bikeStatus;
        }

        public bool IsBroken()
        {
            bikeStatus = false;
            return bikeStatus;
        }

    }
}
