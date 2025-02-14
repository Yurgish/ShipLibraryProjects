using System;

namespace ShipLibrary
{
    /// <summary>
    /// Represents a cruise ship with specific occupied and available seating.
    /// </summary>
    public class CruiseShip : Ship
    {
        
        public int TotalSeats { get; set; } = 1000;

        public int OccupiedSeats { get; set; } = 0;

        public int AvailableSeats => TotalSeats - OccupiedSeats;

        /// <summary>
        /// Constructor to initialize a cruise ship with specific values.
        /// </summary>       
        public CruiseShip(string name, string type, string homePort, double displacement, FullName captainName,
                          int crewCount, DateTime launchDate, double enginePower, int totalSeats, int occupiedSeats)
            : base(name, type, homePort, displacement, captainName, crewCount, launchDate, enginePower)
        {
            TotalSeats = totalSeats;
            OccupiedSeats = occupiedSeats;
        }

        /// <summary>
        /// Default constructor initializes the cruise ship with default values.
        /// </summary>
        public CruiseShip() : base() { }

        /// <summary>
        /// Overrides the ToString method to return information about the cruise ship.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + $", Total Seats: {TotalSeats}, Occupied Seats: {OccupiedSeats}, Available Seats: {AvailableSeats}";
        }
    }
}
