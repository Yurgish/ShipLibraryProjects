using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipLibrary
{
    /// <summary>
    /// Represents a cargo ship with specific cargo type and capacity.
    /// </summary>
    public class CargoShip : Ship
    {
        /// <summary>
        /// Gets or sets the type of cargo the ship carries.
        /// </summary>
        public string CargoType { get; set; } = "Unknown Cargo";

        /// <summary>
        /// Gets or sets the cargo capacity of the ship in tons.
        /// </summary>
        public double CargoCapacity { get; set; } = 0;

        /// <summary>
        /// Constructor to initialize a cargo ship with specific values.
        /// </summary>
        public CargoShip(string name, string type, string homePort, double displacement, FullName captainName,
                         int crewCount, DateTime launchDate, double enginePower, string cargoType, double cargoCapacity)
            : base(name, type, homePort, displacement, captainName, crewCount, launchDate, enginePower)
        {
            CargoType = cargoType;
            CargoCapacity = cargoCapacity;
        }

        /// <summary>
        /// Default constructor initializes the cargo ship with default values.
        /// </summary>
        public CargoShip() : base() { }

        public override string ToString()
        {
            return base.ToString() + $", Cargo Type: {CargoType}, Cargo Capacity: {CargoCapacity} tons";
        }
    }
}
