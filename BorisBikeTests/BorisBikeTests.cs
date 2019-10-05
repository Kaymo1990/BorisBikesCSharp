using BorisBikes;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class BorisBikeTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Category("DockingStation Tests")]
        [Test]

        public void ReleaseBike_ShouldRaiseException_WhenNoBikesDocked()
        {
            var dockingStation = new DockingStation();
            Assert.Throws<Exception>(() => dockingStation.ReleaseBike());
        }

        [Test]

        public void ReleaseBike_ShouldReturnBike_WhenCalled()
        {
            var dockingStation = new DockingStation();
            var bike = new Bike();
            dockingStation.DockBike(bike);
            Assert.IsInstanceOf(typeof(Bike), dockingStation.ReleaseBike());
        }

        [Test]

        public void ReleaseBike_ShouldReturnWorkingBike_WhenIsWorkingCalled()
        {
            var dockingStation = new DockingStation();
            var bike = new Bike();
            dockingStation.DockBike(bike);
            Assert.IsTrue(dockingStation.ReleaseBike().IsWorking());
        }

        [Test]
        public void BikeDock_ShouldHave0Bikes_WhenInstantiated()
        {
            var dockingstation = new DockingStation();
            Assert.AreEqual(0, dockingstation.bikeDock.Count);
        }

        [Category("Bike Tests")]
        [Test]
        public void IsWorking_ShouldReturnTrue_IfWorking()
        {
            var bike = new Bike();
            Assert.IsTrue(bike.IsWorking());
        }
    }
}