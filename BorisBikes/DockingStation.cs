using System;
using System.Collections.Generic;

namespace BorisBikes
{
    public class DockingStation
    {
        public List<Bike> bikeDock = new List<Bike>();
        public Bike ReleaseBike()
        {
            if(bikeDock.Count == 0)
            {
                throw new Exception("No bikes available");
            }
                bikeDock.RemoveAt(bikeDock.Count - 1);
                var bike = new Bike();
                return bike;
        }

        public void DockBike(Bike bike)
        {
            bikeDock.Add(bike);
        }
    }
}