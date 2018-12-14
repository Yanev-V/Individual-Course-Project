namespace F1Cafe.Common.Exceptions.Teams
{
    public class InvalidTeamException : F1CafeBaseException
    {
        private const string message = "Team not found!";

        public InvalidTeamException()
            : base(message)
        {
        }
    }
}
