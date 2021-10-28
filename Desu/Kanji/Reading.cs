namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Reading : IReading, IEquatable<Reading>
    {
        public ReadingType Type { get; }

        public string Value { get; }

        public Reading(ReadingType readingType, string value)
        {
            Type = readingType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Reading);
        }

        public bool Equals(Reading other)
        {
            return other != null &&
                   EqualityComparer<ReadingType>.Default.Equals(Type, other.Type) &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1265339359;
            hashCode = hashCode * -1521134295 + EqualityComparer<ReadingType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }
    }
}