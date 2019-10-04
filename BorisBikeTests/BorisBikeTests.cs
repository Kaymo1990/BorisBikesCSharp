using BorisBikes;
using NUnit.Framework;

namespace Tests
{
    public class BorisBikeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void ReleaseBike_ShouldReturnBike_WhenCalled()
        {
            var dockingStation = new DockingStation();
            Assert.IsInstanceOf(typeof(Bike), dockingStation.ReleaseBike());
        }
    }
}