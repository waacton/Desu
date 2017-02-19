namespace Wacton.Desu.Kanjidict
{
    public interface IReference
    {
        ReferenceType Type { get; }
        
        string Value { get; }
    }
}
