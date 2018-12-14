using System;

namespace F1Cafe.Common
{
    public static class CoreValidator
    {
        public static void ThrowIfNull(object obj, Exception exception = null)
        {
            exception = exception ?? new ArgumentNullException(nameof(obj));

            if (obj == null)
            {
                throw exception;
            }
        }
    }
}
