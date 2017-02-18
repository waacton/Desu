namespace Wacton.Desu.Kanjidict
{
    public interface IVariant
    {
        VariantType Type { get; }
        
        string Value { get; }
    }
}
