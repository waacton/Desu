namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Variant : IVariant, IEquatable<Variant>
    {
        public VariantType Type { get; }

        public string Value { get; }

        public Variant(VariantType variantType, string value)
        {
            Type = variantType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Variant);
        }

        public bool Equals(Variant other)
        {
            return other != null &&
                   EqualityComparer<VariantType>.Default.Equals(Type, other.Type) &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1265339359;
            hashCode = hashCode * -1521134295 + EqualityComparer<VariantType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }
    }
}