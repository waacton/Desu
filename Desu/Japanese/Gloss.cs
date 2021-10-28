namespace Wacton.Desu.Japanese
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Gloss : IGloss, IEquatable<Gloss>
    {
        public string Term { get; }
        public Language Language { get; }
        public GlossType Type { get; }

        /// <summary> This property appears to be unused (JMdict 1.08) </summary>
        public string Gender { get; }

        public Gloss(string term, Language language, GlossType type, string gender)
        {
            this.Term = term;
            this.Language = language;
            this.Type = type;
            this.Gender = gender;
        }

        public override string ToString() => $"{this.Language}: {this.Term}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Gloss);
        }

        public bool Equals(Gloss other)
        {
            return other != null &&
                   Term == other.Term &&
                   EqualityComparer<Language>.Default.Equals(Language, other.Language) &&
                   EqualityComparer<GlossType>.Default.Equals(Type, other.Type) &&
                   Gender == other.Gender;
        }

        public override int GetHashCode()
        {
            int hashCode = -467913249;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Term);
            hashCode = hashCode * -1521134295 + EqualityComparer<Language>.Default.GetHashCode(Language);
            hashCode = hashCode * -1521134295 + EqualityComparer<GlossType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Gender);
            return hashCode;
        }
    }
}
