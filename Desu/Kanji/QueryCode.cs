namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class QueryCode : IQueryCode
    {
        public QueryCodeType Type { get; }

        public SkipMisclassification SkipMisclassification { get; }

        public string Value { get; }

        public QueryCode(QueryCodeType codepointType, string value, SkipMisclassification skipMisclassification = null)
        {
            this.Type = codepointType;
            this.SkipMisclassification = skipMisclassification;
            this.Value = value;
        }

        public override string ToString()
        {
            string misclassification = this.SkipMisclassification == null || this.SkipMisclassification == SkipMisclassification.None
                ? string.Empty
                : $" (Misclass: {this.SkipMisclassification})";

            return $"{this.Type}: {this.Value}{misclassification}";
        }
    }
}