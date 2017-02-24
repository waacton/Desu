namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IReading
    {
        ReadingType Type { get; }
        
        string Value { get; }
    }
}
