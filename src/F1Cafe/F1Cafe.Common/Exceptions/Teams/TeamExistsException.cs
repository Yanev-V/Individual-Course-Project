namespace F1Cafe.Common.Exceptions.Teams
{
    public class TeamExistsException : F1CafeBaseException
    {
        private const string message = "Team with such name already exists!";

        public TeamExistsException()
            : base(message)
        {
        }
    }
}
