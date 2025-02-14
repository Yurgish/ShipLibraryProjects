namespace ShipLibrary
{
    /// <summary>
    /// Represents a full name with first, middle, and last names.
    /// </summary>
    public class FullName
    {

        public string LastName { get; set; } = "Unknown";

        public string FirstName { get; set; } = "Unknown";

        public string MiddleName { get; set; } = "Unknown";

        public FullName() { }

        public FullName(string lastName, string firstName, string middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
        }

        /// <summary>
        /// Overrides ToString to return the full name as a string.
        /// </summary>
        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
