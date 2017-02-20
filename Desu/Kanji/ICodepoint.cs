namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface ICodepoint
    {
        CodepointType Type { get; }
        
        string Value { get; }
    }
}
