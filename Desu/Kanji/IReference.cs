namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IReference
    {
        ReferenceType Type { get; }
        
        string Value { get; }
    }
}
