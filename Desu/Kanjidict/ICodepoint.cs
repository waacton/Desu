namespace Wacton.Desu.Kanjidict
{
    public interface ICodepoint
    {
        CodepointType Type { get; }
        
        string Value { get; }
    }
}
