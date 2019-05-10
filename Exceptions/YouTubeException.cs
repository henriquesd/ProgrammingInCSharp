using System;

namespace Exceptions
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
