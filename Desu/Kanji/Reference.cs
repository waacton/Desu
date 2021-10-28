namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Reference : IReference, IEquatable<Reference>
    {
        public ReferenceType Type { get; }

        public string Value { get; }

        public Reference(ReferenceType referenceType, string value)
        {
            Type = referenceType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Reference);
        }

        public bool Equals(Reference other)
        {
            return other != null &&
                   EqualityComparer<ReferenceType>.Default.Equals(Type, other.Type) &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1265339359;
            hashCode = hashCode * -1521134295 + EqualityComparer<ReferenceType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }
    }
}