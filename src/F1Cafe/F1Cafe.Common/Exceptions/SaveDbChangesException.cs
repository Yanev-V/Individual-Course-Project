namespace F1Cafe.Common.Exceptions
{
    public class SaveDbChangesException : F1CafeBaseException
    {
        private const string message = "A problem occurred while saving the data.";

        public SaveDbChangesException()
            : base(message)
        {
        }
    }
}
