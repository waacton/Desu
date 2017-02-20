namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IQueryCode
    {
        QueryCodeType Type { get; }

        SkipMisclassification SkipMisclassification { get; }

        string Value { get; }
    }
}
