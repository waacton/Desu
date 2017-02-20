namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public interface IBushuRadical
    {
        BushuRadicalType Type { get; }
        string Radical { get; }
        int Number { get; }
    }
}
