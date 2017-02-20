namespace Wacton.Desu.Kanji
{
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
    }
}