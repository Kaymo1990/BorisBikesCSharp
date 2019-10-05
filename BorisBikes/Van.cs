using System;
using System.Collections.Generic;
using System.Text;

namespace BorisBikes
{
    public class Van
    {

        public List<Bike> bikeDock = new List<Bike>();

        public void PickupBikeForRepair(DockingStation dockingstation)
        {
            Bike bikeForRepair = dockingstation.bikeDock[dockingstation.bikeDock.Count - 1];
            bikeDock.Add(dockingstation.ReleaseBike());       
        }
    }
}
