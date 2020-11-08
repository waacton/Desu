namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    public class Reference : IReference
    {
        public ReferenceType Type { get; }

        public string Value { get; }

        public Reference(ReferenceType referenceType, string value)
        {
            this.Type = referenceType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }

        public override bool Equals(object obj)
        {
            return obj is Reference reference &&
                   EqualityComparer<ReferenceType>.Default.Equals(Type, reference.Type) &&
                   Value == reference.Value;
        }
    }
}