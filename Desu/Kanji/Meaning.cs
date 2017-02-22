namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class Meaning : IMeaning
    {
        public Language Language { get; }

        public string Term { get; }

        public Meaning(Language language, string term)
        {
            this.Language = language;
            this.Term = term;
        }

        public override string ToString()
        {
            return $"{this.Language}: {this.Term}";
        }
    }
}