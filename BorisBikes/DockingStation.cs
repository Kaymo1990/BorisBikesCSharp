using System;
using System.Collections.Generic;

namespace BorisBikes
{
    public class DockingStation
    {
        public DockingStation(int maxCapacity = 20)
        {
            MAX_CAPACITY = maxCapacity;
        }
        private int mAX_CAPACITY = 20;
        public List<Bike> bikeDock = new List<Bike>();

        public int MAX_CAPACITY { get => mAX_CAPACITY; set => mAX_CAPACITY = value; }

        public Bike ReleaseBike()
        {
            if(IsEmpty())
            {
                throw new Exception("No bikes available");
            }

            if(bikeDock[bikeDock.Count-1].bikeStatus == false)
            {
                throw new Exception("Can't take out broken bike");
            }

                var bikeToReturn = bikeDock[bikeDock.Count - 1];
                bikeDock.RemoveAt(bikeDock.Count - 1);
                return bikeToReturn;
        }

        public void DockBike(Bike bike)
        {
            if (IsFull())
            {
                throw new Exception("The bike dock is full");
            }
            bikeDock.Add(bike);
        }

        private bool IsEmpty()
        {
            if (bikeDock.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool IsFull()
        {
            if (bikeDock.Count == MAX_CAPACITY)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}