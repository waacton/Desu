namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class Reading : IReading
    {
        public KanjiReadingType Type { get; }

        public string Value { get; }

        public Reading(KanjiReadingType kanjiReadingType, string value)
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