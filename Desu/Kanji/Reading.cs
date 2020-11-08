namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
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

        public override bool Equals(object obj)
        {
            return obj is Reading reading &&
                   EqualityComparer<ReadingType>.Default.Equals(Type, reading.Type) &&
                   Value == reading.Value;
        }
    }
}