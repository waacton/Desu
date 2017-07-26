using System;

namespace Wacton.Desu.Romaji
{
    public class TransliterationException : Exception
    {
        public TransliterationException(string message)
            : base(message)
        {
        }
    }
}
