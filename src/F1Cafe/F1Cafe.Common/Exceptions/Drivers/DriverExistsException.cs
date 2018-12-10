namespace F1Cafe.Common.Exceptions.Drivers
{
    public class DriverExistsException : F1CafeBaseException
    {
        private const string message = "Driver with such names already exists!";

        public DriverExistsException()
            : base(message)
        {
        }
    }
}
