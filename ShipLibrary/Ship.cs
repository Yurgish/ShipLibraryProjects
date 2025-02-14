namespace ShipLibrary
{
    /// <summary>
    /// Represents the base class for a ship.
    /// </summary>
    public class Ship
    {
        public string Name { get; set; } = "Unknown Ship";

        public string Type { get; set; } = "Unknown Type";

        public string HomePort { get; set; } = "Unknown Port";

        private double _displacement;
        public double Displacement
        {
            get => _displacement;
            set => _displacement = value < 0 ? 0 : value; 
        }

        public FullName CaptainName { get; set; } = new();

        private int _crewCount;
        public int CrewCount
        {
            get => _crewCount;
            set => _crewCount = value < 0 ? 0 : value;
        }

        public DateTime LaunchDate { get; set; } = DateTime.Now;
        
        private double _enginePower;

        /// <summary>
        /// The engine power in kilowatts.
        /// </summary>
        public double EnginePower
        {
            get => _enginePower;
            set => _enginePower = value < 0 ? 0 : value; 
        }

        private double _currentSpeed;

        /// <summary>
        /// The current speed of the ship in knots.
        /// </summary>
        public double CurrentSpeed
        {
            get => _currentSpeed;
            set => _currentSpeed = value < 0 ? 0 : value;
        }

        public Ship() { }

        public Ship(string name, string type, string homePort, double displacement, FullName captainName, int crewCount,
                    DateTime launchDate, double enginePower)
        {
            Name = name;
            Type = type;
            HomePort = homePort;
            Displacement = displacement;
            CaptainName = captainName;
            CrewCount = crewCount;
            LaunchDate = launchDate;
            EnginePower = enginePower;
            _currentSpeed = 0;
        }

        /// <summary>
        /// Overrides the ToString method to return ship information.
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Home Port: {HomePort}, Displacement: {Displacement} tons, " +
                   $"Captain: {CaptainName}, Crew Count: {CrewCount}, Launch Date: {LaunchDate.ToShortDateString()}, " +
                   $"Engine Power: {EnginePower} kW, Current Speed: {CurrentSpeed} knots.";
        }

        /// <summary>  
        /// Prints the ship's information in a specified format.  
        /// </summary>  
        /// <param name="format">The format string to use for printing the ship's information.</param>  
        public void PrintInfo(string format)
        {
            Console.WriteLine(string.Format(format, Name, Type, HomePort, Displacement, CaptainName, CrewCount, CurrentSpeed));
        }
    }
}
