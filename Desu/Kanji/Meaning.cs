namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Meaning : IMeaning
    {
        public Language Language { get; }

        public string Term { get; }

        public Meaning(Language language, string term)
        {
            Language = language;
            Term = term;
        }

        public override string ToString() => $"{Language}: {Term}";

        public override bool Equals(object obj)
        {
            return obj is Meaning meaning &&
                   EqualityComparer<Language>.Default.Equals(Language, meaning.Language) &&
                   Term == meaning.Term;
        }
    }
}