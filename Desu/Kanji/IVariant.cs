namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IVariant
    {
        VariantType Type { get; }
        
        string Value { get; }
    }
}
