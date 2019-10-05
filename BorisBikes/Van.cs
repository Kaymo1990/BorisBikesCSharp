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
            bikeDock.Add(bikeForRepair);
            dockingstation.bikeDock.RemoveAt(dockingstation.bikeDock.Count - 1);
        }

        public object ReleaseBikeForRepair()
        {
            if (bikeDock.Count == 0)
            {
                throw new Exception("No bikes held by van");
            }
            Bike bikeForRepair = bikeDock[bikeDock.Count - 1];
            bikeDock.RemoveAt(bikeDock.Count - 1);
            return bikeForRepair;
        }
    }
}
