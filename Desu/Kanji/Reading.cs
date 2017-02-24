namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class Reading : IReading
    {
        public ReadingType Type { get; }

        public string Value { get; }

        public Reading(ReadingType readingType, string value)
        {
            this.Type = readingType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }
    }
}