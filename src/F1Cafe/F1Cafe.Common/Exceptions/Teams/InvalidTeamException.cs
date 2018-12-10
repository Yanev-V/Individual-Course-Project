namespace F1Cafe.Common.Exceptions.Teams
{
    public class InvalidTeamException : F1CafeBaseException
    {
        private const string message = "Invalid team name!";

        public InvalidTeamException()
            : base(message)
        {
        }
    }
}
