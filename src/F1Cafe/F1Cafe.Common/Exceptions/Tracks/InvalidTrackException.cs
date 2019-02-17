namespace F1Cafe.Common.Exceptions.Tracks
{
    public class InvalidTrackException : F1CafeBaseException
    {
        private const string message = "Track not found!";

        public InvalidTrackException()
            : base(message)
        {
        }
    }
}
