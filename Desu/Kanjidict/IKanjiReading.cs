namespace Wacton.Desu.Kanjidict
{
    public interface IKanjiReading
    {
        KanjiReadingType Type { get; }
        
        string Value { get; }
    }
}
