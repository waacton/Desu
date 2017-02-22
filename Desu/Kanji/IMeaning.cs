namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IMeaning
    {
        Language Language { get; }
        
        string Term { get; }
    }
}
