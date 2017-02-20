namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IKanjiMeaning
    {
        Language Language { get; }
        
        string Term { get; }
    }
}
