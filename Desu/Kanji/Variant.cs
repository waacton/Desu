namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Variant : IVariant
    {
        public VariantType Type { get; }

        public string Value { get; }

        public Variant(VariantType variantType, string value)
        {
            Type = variantType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        public override bool Equals(object obj)
        {
            return obj is Variant variant &&
                   EqualityComparer<VariantType>.Default.Equals(Type, variant.Type) &&
                   Value == variant.Value;
        }
    }
}