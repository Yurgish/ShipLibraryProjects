using ShipLibrary;

namespace ShipLibrary.Tests
{
    [TestClass]
    public class CargoShipTests
    {
        [TestMethod]
        public void CargoShip_DefaultConstructor_ReturnsDefaultValues()
        {
            CargoShip cargoShip = new();

            Assert.AreEqual("Unknown Ship", cargoShip.Name);
            Assert.AreEqual("Unknown Type", cargoShip.Type);
            Assert.AreEqual("Unknown Port", cargoShip.HomePort);
            Assert.AreEqual(0, cargoShip.Displacement);
            Assert.AreEqual("Unknown Unknown Unknown", cargoShip.CaptainName.ToString());
            Assert.AreEqual(0, cargoShip.CrewCount);
            Assert.AreEqual(DateTime.Now.ToShortDateString(), cargoShip.LaunchDate.ToShortDateString()); // без точного часу
            Assert.AreEqual(0, cargoShip.EnginePower);
            Assert.AreEqual(0, cargoShip.CurrentSpeed);
            Assert.AreEqual("Unknown Cargo", cargoShip.CargoType);
            Assert.AreEqual(0, cargoShip.CargoCapacity);
        }

        [TestMethod]
        public void CargoShip_ParameterizedConstructor_ReturnsCorrectCargoShipInfo()
        {
            FullName captainName = new("Smith", "John", "Middle");
            DateTime launchDate = new(2000, 5, 10);

            CargoShip cargoShip = new("Cargo King", "Cargo", "New York", 50000.0, captainName, 25, launchDate, 10000, "General Cargo", 20000);

            Assert.AreEqual("Cargo King", cargoShip.Name);
            Assert.AreEqual("Cargo", cargoShip.Type);
            Assert.AreEqual("New York", cargoShip.HomePort);
            Assert.AreEqual(50000.0, cargoShip.Displacement);
            Assert.AreEqual(captainName.ToString(), cargoShip.CaptainName.ToString());
            Assert.AreEqual(25, cargoShip.CrewCount);
            Assert.AreEqual(launchDate, cargoShip.LaunchDate);
            Assert.AreEqual(10000, cargoShip.EnginePower);
            Assert.AreEqual(0, cargoShip.CurrentSpeed); // За замовчуванням швидкість 0
            Assert.AreEqual("General Cargo", cargoShip.CargoType);
            Assert.AreEqual(20000, cargoShip.CargoCapacity);
        }

        [TestMethod]
        public void CargoShip_SetCargoCapacity_LessThanZero_SetsCargoCapacityToZero()
        {
            CargoShip cargoShip = new()
            {
                CargoCapacity = -20000
            };

            Assert.AreEqual(0, cargoShip.CargoCapacity);
        }

        [TestMethod]
        public void CargoShip_SetCargoCapacity_ValidCargoCapacity_SetsCargoCapacityCorrectly()
        {
            CargoShip cargoShip = new()
            {
                CargoCapacity = 25000
            };

            Assert.AreEqual(25000, cargoShip.CargoCapacity);
        }
    }
}
