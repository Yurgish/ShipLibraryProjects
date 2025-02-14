using System;
using System.Reflection.PortableExecutable;
using ShipLibrary;

namespace ShipConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "{0,-20} {1,-10} {2,-15} {3,-15} {4,-20} {5,-15} {6,-10}";

            Ship ship = new("Titanic", "Passenger", "Southampton", 46000, new FullName("John", "Doe", "Smith"), 1000, DateTime.Parse("1912-04-10"), 25000);
            CargoShip cargoShip = new("Cargomax", "Cargo", "Hamburg", 50000, new FullName("Alice", "Brown", "Johnson"), 25, DateTime.Parse("2005-06-15"), 12000, "General Cargo", 20000);
            CruiseShip cruiseShip = new("OceanLiner", "Cruise", "Miami", 80000, new FullName("Michael", "Clark", "Davis"), 1200, DateTime.Parse("2010-12-05"), 50000, 2000, 1500);

            cruiseShip.CurrentSpeed = 25;
            cargoShip.CurrentSpeed = 5;
            ship.CurrentSpeed = -10;

            string header = string.Format(format, "Name", "Type", "Home Port", "Displacement", "Captain Name", "Crew Count", "Current Speed");

            string separator = new('-', header.Length);
            Console.WriteLine(separator);
            Console.WriteLine(header);
            Console.WriteLine(separator);

            ship.PrintInfo(format);
            cargoShip.PrintInfo(format);
            cruiseShip.PrintInfo(format);
            Console.WriteLine(separator);

            Console.ReadLine();
        }
    }
}
