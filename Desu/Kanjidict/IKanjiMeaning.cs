namespace Wacton.Desu.Kanjidict
{
    public interface IKanjiMeaning
    {
        Language Language { get; }
        
        string Term { get; }
    }
}
