namespace F1Cafe.Common.Exceptions.Drivers
{
    public class InvalidDriverException : F1CafeBaseException
    {
        private const string message = "Driver not found!";

        public InvalidDriverException()
            : base(message)
        {
        }
    }
}
