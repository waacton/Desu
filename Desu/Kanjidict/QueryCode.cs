namespace Wacton.Desu.Kanjidict
{
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
            return $"{this.Type}: {this.Value}{(this.SkipMisclassification != null ? $" (Misclass: {this.SkipMisclassification})" : string.Empty)}";
        }
    }
}