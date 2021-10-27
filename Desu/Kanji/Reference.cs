namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Reference : IReference
    {
        public ReferenceType Type { get; }

        public string Value { get; }

        public Reference(ReferenceType referenceType, string value)
        {
            Type = referenceType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        public override bool Equals(object obj)
        {
            return obj is Reference reference &&
                   EqualityComparer<ReferenceType>.Default.Equals(Type, reference.Type) &&
                   Value == reference.Value;
        }
    }
}