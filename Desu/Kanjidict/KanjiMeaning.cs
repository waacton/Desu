namespace Wacton.Desu.Kanjidict
{
    public class KanjiMeaning : IKanjiMeaning
    {
        public Language Language { get; }

        public string Term { get; }

        public KanjiMeaning(Language language, string term)
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