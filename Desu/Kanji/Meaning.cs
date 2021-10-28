namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Meaning : IMeaning, IEquatable<Meaning>
    {
        public Language Language { get; }

        public string Term { get; }

        public Meaning(Language language, string term)
        {
            Language = language;
            Term = term;
        }

        public override string ToString() => $"{Language}: {Term}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Meaning);
        }

        public bool Equals(Meaning other)
        {
            return other != null &&
                   EqualityComparer<Language>.Default.Equals(Language, other.Language) &&
                   Term == other.Term;
        }

        public override int GetHashCode()
        {
            int hashCode = 686427594;
            hashCode = hashCode * -1521134295 + EqualityComparer<Language>.Default.GetHashCode(Language);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Term);
            return hashCode;
        }
    }
}