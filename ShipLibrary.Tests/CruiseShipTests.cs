using ShipLibrary;

namespace ShipLibrary.Tests
{
    [TestClass]
    public class CruiseShipTests
    {
        [TestMethod]
        public void CruiseShip_DefaultConstructor_ReturnsDefaultValues()
        {
            CruiseShip cruiseShip = new();

            Assert.AreEqual("Unknown Ship", cruiseShip.Name);
            Assert.AreEqual("Unknown Type", cruiseShip.Type);
            Assert.AreEqual("Unknown Port", cruiseShip.HomePort);
            Assert.AreEqual(0, cruiseShip.Displacement);
            Assert.AreEqual(new FullName("Unknown", "Unknown", "Unknown").ToString(), cruiseShip.CaptainName.ToString());
            Assert.AreEqual(0, cruiseShip.CrewCount);
            Assert.AreEqual(DateTime.Today.Date, cruiseShip.LaunchDate.Date);
            Assert.AreEqual(0, cruiseShip.EnginePower);
            Assert.AreEqual(0, cruiseShip.CurrentSpeed);
            Assert.AreEqual(1000, cruiseShip.TotalSeats);
            Assert.AreEqual(0, cruiseShip.OccupiedSeats);
            Assert.AreEqual(1000, cruiseShip.AvailableSeats);
        }

        [TestMethod]
        public void CruiseShip_ParameterizedConstructor_ReturnsCorrectCruiseShipInfo()
        {
            FullName captainName = new("Smith", "John", "Middle");
            DateTime launchDate = new(1936, 5, 27);

            CruiseShip cruiseShip = new("Queen Mary", "Cruise", "Los Angeles", 76000.0, captainName, 1500, launchDate, 80000, 1000, 500);

            Assert.AreEqual("Queen Mary", cruiseShip.Name);
            Assert.AreEqual("Cruise", cruiseShip.Type);
            Assert.AreEqual("Los Angeles", cruiseShip.HomePort);
            Assert.AreEqual(76000.0, cruiseShip.Displacement);
            Assert.AreEqual(captainName.ToString(), cruiseShip.CaptainName.ToString());
            Assert.AreEqual(1500, cruiseShip.CrewCount);
            Assert.AreEqual(launchDate, cruiseShip.LaunchDate);
            Assert.AreEqual(80000, cruiseShip.EnginePower);
            Assert.AreEqual(0, cruiseShip.CurrentSpeed);
            Assert.AreEqual(1000, cruiseShip.TotalSeats);
            Assert.AreEqual(500, cruiseShip.OccupiedSeats);
            Assert.AreEqual(500, cruiseShip.AvailableSeats);
        }

        [TestMethod]
        public void CruiseShip_SetOccupiedSeats_LessThanZero_SetsOccupiedSeatsToZero()
        {
            CruiseShip cruiseShip = new()
            {
                OccupiedSeats = -10
            };

            Assert.AreEqual(0, cruiseShip.OccupiedSeats);
        }

        [TestMethod]
        public void CruiseShip_SetOccupiedSeats_ValidValue_SetsOccupiedSeatsCorrectly()
        {
            CruiseShip cruiseShip = new()
            {
                OccupiedSeats = 500
            };

            Assert.AreEqual(500, cruiseShip.OccupiedSeats);
        }

        [TestMethod]
        public void CruiseShip_SetTotalSeats_LessThanZero_SetsTotalSeatsToZero()
        {
            CruiseShip cruiseShip = new()
            {
                TotalSeats = -1000
            };

            Assert.AreEqual(0, cruiseShip.TotalSeats);
        }

        [TestMethod]
        public void CruiseShip_AvailableSeats_ReturnsCorrectValue()
        {
            CruiseShip cruiseShip = new()
            {
                TotalSeats = 1000,
                OccupiedSeats = 500
            };

            Assert.AreEqual(500, cruiseShip.AvailableSeats);
        }
    }
}
