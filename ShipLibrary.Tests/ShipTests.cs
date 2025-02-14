namespace ShipLibrary.Tests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void Ship_DefaultConstructor_ReturnsDefaultValues()
        {
            Ship ship = new();

            Assert.AreEqual("Unknown Ship", ship.Name);
            Assert.AreEqual("Unknown Type", ship.Type);
            Assert.AreEqual("Unknown Port", ship.HomePort);
            Assert.AreEqual(0, ship.Displacement);
            Assert.AreEqual(new FullName("Unknown", "Unknown", "Unknown").ToString(), ship.CaptainName.ToString());
            Assert.AreEqual(0, ship.CrewCount);
            Assert.AreEqual(DateTime.Today.Date, ship.LaunchDate.Date);
            Assert.AreEqual(0, ship.EnginePower);
            Assert.AreEqual(0, ship.CurrentSpeed);
        }

        [TestMethod]
        public void Ship_ParameterizedConstructor_ReturnsCorrectShipInfo()
        {
            FullName captainName = new("Smith", "John", "Middle");

            Ship ship = new("Titanic", "Cruise", "New York", 52310.0, captainName, 900, new DateTime(1912, 4, 10), 50000);

            Assert.AreEqual("Titanic", ship.Name);
            Assert.AreEqual("Cruise", ship.Type);
            Assert.AreEqual("New York", ship.HomePort);
            Assert.AreEqual(52310.0, ship.Displacement);
            Assert.AreEqual(captainName.ToString(), ship.CaptainName.ToString());
            Assert.AreEqual(900, ship.CrewCount);
            Assert.AreEqual(new DateTime(1912, 4, 10), ship.LaunchDate);
            Assert.AreEqual(50000, ship.EnginePower);
            Assert.AreEqual(0, ship.CurrentSpeed);
        }


        [TestMethod]
        public void Ship_SetCurrentSpeed_LessThanZero_SetsSpeedToZero()
        {
            Ship ship = new()
            {
                CurrentSpeed = -10
            };

            Assert.AreEqual(0, ship.CurrentSpeed);
        }

        [TestMethod]
        public void Ship_SetCurrentSpeed_ValidSpeed_SetsSpeedCorrectly()
        {
            Ship ship = new()
            {
                CurrentSpeed = 25
            };

            Assert.AreEqual(25, ship.CurrentSpeed);
        }

        [TestMethod]
        public void Ship_SetDisplacement_LessThanZero_SetsDisplacementToZero()
        {
            Ship ship = new()
            {
                Displacement = -5000
            };

            Assert.AreEqual(0, ship.Displacement);
        }

        public void Ship_SetDisplacement_ValidDisplacement_SetsDisplacementCorrectly()
        {
            Ship ship = new()
            {
                Displacement = 3400
            };

            Assert.AreEqual(3400, ship.Displacement);
        }

        [TestMethod]
        public void Ship_SetCrewCount_LessThanZero_SetsCrewCountToZero()
        {
            Ship ship = new()
            {
                CrewCount = -5
            };

            Assert.AreEqual(0, ship.CrewCount);
        }

        [TestMethod]
        public void Ship_SetCrewCount_ValidCrewCount_SetsCrewCountCorrectly()
        {
            Ship ship = new()
            {
                CrewCount = 200
            };

            Assert.AreEqual(200, ship.CrewCount);
        }

        [TestMethod]
        public void Ship_SetEnginePower_LessThanZero_SetsEnginePowerToZero()
        {
            Ship ship = new()
            {
                EnginePower = -1000
            };

            Assert.AreEqual(0, ship.EnginePower);
        }

        [TestMethod]
        public void Ship_SetEnginePower_ValidEnginePower_SetsEnginePowerCorrectly()
        {
            Ship ship = new()
            {
                EnginePower = 2000
            };

            Assert.AreEqual(2000, ship.EnginePower);
        }

        [TestMethod]
        public void Ship_PrintInfo_ValidFormat_PrintsCorrectInfo()
        {
            FullName captainName = new("Smith", "John", "Middle");

            Ship ship = new("Titanic", "Cruise", "New York", 52310.0, captainName, 900, new DateTime(1912, 4, 10), 50000);

            string format = "Ship Name: {0}, Type: {1}, Home Port: {2}, Displacement: {3} tons, Captain: {4}, Crew: {5}, Speed: {6} knots";

            System.IO.StringWriter stringWriter = new();
            Console.SetOut(stringWriter);

            ship.PrintInfo(format);

            string result = stringWriter.ToString().Trim();

            Assert.AreEqual("Ship Name: Titanic, Type: Cruise, Home Port: New York, Displacement: 52310 tons, Captain: Smith John Middle, Crew: 900, Speed: 0 knots", result);
        }
    }
}
