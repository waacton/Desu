namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    public class Variant : IVariant
    {
        public VariantType Type { get; }

        public string Value { get; }

        public Variant(VariantType variantType, string value)
        {
            this.Type = variantType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }

        public override bool Equals(object obj)
        {
            return obj is Variant variant &&
                   EqualityComparer<VariantType>.Default.Equals(Type, variant.Type) &&
                   Value == variant.Value;
        }
    }
}