namespace Wacton.Desu.Kanjidict
{
    public interface IQueryCode
    {
        QueryCodeType Type { get; }

        SkipMisclassification SkipMisclassification { get; }

        string Value { get; }
    }
}
