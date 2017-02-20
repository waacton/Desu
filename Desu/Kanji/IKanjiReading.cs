namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IKanjiReading
    {
        KanjiReadingType Type { get; }
        
        string Value { get; }
    }
}
