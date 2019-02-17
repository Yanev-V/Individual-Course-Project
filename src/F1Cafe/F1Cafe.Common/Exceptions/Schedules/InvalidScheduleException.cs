namespace F1Cafe.Common.Exceptions.Schedules
{
    public class InvalidScheduleException : F1CafeBaseException
    {
        private const string message = "Schedule not found!";

        public InvalidScheduleException()
            : base(message)
        {
        }
    }
}
