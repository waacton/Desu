namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class QueryCode : IQueryCode, IEquatable<QueryCode>
    {
        public QueryCodeType Type { get; }

        public SkipMisclassification SkipMisclassification { get; }

        public string Value { get; }

        public QueryCode(QueryCodeType codepointType, string value, SkipMisclassification skipMisclassification = null)
        {
            Type = codepointType;
            SkipMisclassification = skipMisclassification;
            Value = value;
        }

        public override string ToString()
        {
            var misclassification = SkipMisclassification == null || SkipMisclassification == SkipMisclassification.None
                ? string.Empty
                : $" (Misclass: {SkipMisclassification})";

            return $"{Type}: {Value}{misclassification}";
        }

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as QueryCode);
        }

        public bool Equals(QueryCode other)
        {
            return other != null &&
                   EqualityComparer<QueryCodeType>.Default.Equals(Type, other.Type) &&
                   EqualityComparer<SkipMisclassification>.Default.Equals(SkipMisclassification, other.SkipMisclassification) &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = -199580984;
            hashCode = hashCode * -1521134295 + EqualityComparer<QueryCodeType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<SkipMisclassification>.Default.GetHashCode(SkipMisclassification);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            return hashCode;
        }
    }
}