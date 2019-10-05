using BorisBikes;
using NUnit.Framework;
using System;
using Moq;
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

        public void DockBike_ShouldRaiseException_WhenMaxBikesDocked()
        {
            var dockingStation = new DockingStation();
            for(var i = 0; i < 20; i++)
            {
                dockingStation.DockBike(new Bike());
            }
            Assert.Throws<Exception>(() => dockingStation.DockBike(new Bike()));
        }

        [Test]
        public void DockBike_ShouldRaiseException_WhenMax10BikesDocked()
        {
            var dockingStation = new DockingStation(10);
            for (var i = 0; i <10; i++)
            {
                dockingStation.DockBike(new Bike());
            }
            Assert.Throws<Exception>(() => dockingStation.DockBike(new Bike()));
        }

        [Test]
        public void DockBike_ShouldPass_WhenMax10BikesFor9Docked()
        {
            var dockingStation = new DockingStation(10);
            for (var i = 0; i < 9; i++)
            {
                dockingStation.DockBike(new Bike());
            }
            Assert.AreEqual(9, dockingStation.bikeDock.Count);
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

        public void ReleaseBike_ShouldReturnFakeBike_WhenCalled()
        {
            var dockingStation = new DockingStation();
            var Fakebike = new Mock<Bike>();
            dockingStation.DockBike(Fakebike.Object);
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
        public void ReleaseBike_ShouldRaiseException_WhenBikeIsBroken()
        {
            var dockingStation = new DockingStation(10);
            var bike = new Bike();
            bike.IsBroken();
            dockingStation.DockBike(bike);

            Assert.Throws<Exception>(() => dockingStation.ReleaseBike());
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

        [Test]
        public void IsWorking_ShouldReturnTrue_IfWorkingForFakeBike()
        {
            var Fakebike = new Mock<Bike>();
            Assert.IsTrue(Fakebike.Object.bikeStatus);
        }

        [Test]
        public void IsWorking_ShouldReturnFalse_IfBroken()
        {
            var bike = new Bike();
            bike.IsBroken();
            Assert.IsFalse(bike.IsWorking());
        }
    }
}