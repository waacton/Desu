namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IIndexRadical
    {
        IndexRadicalType Type { get; }
        string Radical { get; }
        int Number { get; }
    }
}
