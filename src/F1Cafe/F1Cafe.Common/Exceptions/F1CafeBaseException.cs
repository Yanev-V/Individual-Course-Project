using System;

namespace F1Cafe.Common.Exceptions
{
    public abstract class F1CafeBaseException : Exception
    {
        public F1CafeBaseException(string message)
            : base(message)
        {
        }
    }
}
