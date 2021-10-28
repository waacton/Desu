namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class Codepoint : ICodepoint, IEquatable<Codepoint>
    {
        public CodepointType Type { get; }

        public string Value { get; }

        public Codepoint(CodepointType codepointType, string value)
        {
            Type = codepointType;
            Value = value;
        }

        public override string ToString() => $"{Type}: {Value}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as Codepoint);
        }

        public bool Equals(Codepoint other)
        {
            return other != null &&
                   EqualityComparer<CodepointType>.Default.Equals(Type, other.Type) &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1265339359;
            hashCode = hashCode * -1521134295 + EqualityComparer<CodepointType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }
    }
}