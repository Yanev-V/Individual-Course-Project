namespace F1Cafe.Common.Exceptions.Races
{
    public class InvalidRaceException : F1CafeBaseException
    {
        private const string message = "Race not found!";

        public InvalidRaceException()
            : base(message)
        {
        }
    }
}
