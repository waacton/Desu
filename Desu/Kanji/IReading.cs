namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IReading
    {
        KanjiReadingType Type { get; }
        
        string Value { get; }
    }
}
