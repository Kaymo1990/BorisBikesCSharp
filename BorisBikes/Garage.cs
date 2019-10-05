using System;
using System.Collections.Generic;
using System.Text;

namespace BorisBikes
{
    public class Garage
    {
        public List<Bike> bikeDock = new List<Bike>();

        public void TakeBikeForRepair(Van van)
        {
            var bikeToRepair = van.ReleaseBikeForRepair();
            bikeDock.Add(bikeToRepair);
        }
    }
}
