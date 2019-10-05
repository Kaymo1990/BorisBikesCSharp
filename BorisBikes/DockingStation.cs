﻿using System;
using System.Collections.Generic;

namespace BorisBikes
{
    public class DockingStation
    {
        private const int mAX_CAPACITY = 20;
        public List<Bike> bikeDock = new List<Bike>();

        public int MAX_CAPACITY { get => mAX_CAPACITY; }

        public Bike ReleaseBike()
        {
            if(IsEmpty())
            {
                throw new Exception("No bikes available");
            }
                bikeDock.RemoveAt(bikeDock.Count - 1);
                var bike = new Bike();
                return bike;
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