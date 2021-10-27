namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class QueryCode : IQueryCode
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

        public override bool Equals(object obj)
        {
            return obj is QueryCode code &&
                   EqualityComparer<QueryCodeType>.Default.Equals(Type, code.Type) &&
                   EqualityComparer<SkipMisclassification>.Default.Equals(SkipMisclassification, code.SkipMisclassification) &&
                   Value == code.Value;
        }
    }
}