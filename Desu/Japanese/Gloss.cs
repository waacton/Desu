namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Gloss : IGloss
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

        public override bool Equals(object obj)
        {
            return obj is Gloss gloss &&
                   Term == gloss.Term &&
                   EqualityComparer<Language>.Default.Equals(Language, gloss.Language) &&
                   EqualityComparer<GlossType>.Default.Equals(Type, gloss.Type) &&
                   Gender == gloss.Gender;
        }
    }
}
