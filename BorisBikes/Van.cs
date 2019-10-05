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
            var bikeForRepair = dockingstation.bikeDock[-1];
            bikeDock.Add(bikeForRepair);
            dockingstation.bikeDock.RemoveAt(dockingstation.bikeDock.Count - 1);
        }
    }
}
