namespace Wacton.Desu.Kanjidict
{
    public class KanjiReading : IKanjiReading
    {
        public KanjiReadingType Type { get; }

        public string Value { get; }

        public KanjiReading(KanjiReadingType kanjiReadingType, string value)
        {
            this.Type = kanjiReadingType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }
    }
}