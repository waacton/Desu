namespace Wacton.Desu.Japanese
{
    using Wacton.Desu.Enums;

    public class Gloss
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

        public override string ToString()
        {
            return $"{this.Language}: {this.Term}";
        }
    }
}
