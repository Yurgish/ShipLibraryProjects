using ShipLibrary;

namespace ShipLibrary.Tests
{
    [TestClass]
    public sealed class FullNameTests
    {
        [TestMethod]
        public void FullName_DefaultConstructor_ReturnsUnknownNames()
        {
            FullName fullName = new();

            string result = fullName.ToString();

            Assert.AreEqual("Unknown Unknown Unknown", result);
        }

        [TestMethod]
        public void FullName_ParameterizedConstructor_ReturnsCorrectFullName()
        {
            FullName fullName = new("Doe", "John", "Middle");

            string result = fullName.ToString();

            Assert.AreEqual("Doe John Middle", result);
        }
    }
}
