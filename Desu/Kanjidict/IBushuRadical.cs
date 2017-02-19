namespace Wacton.Desu.Kanjidict
{
    public interface IBushuRadical
    {
        BushuRadicalType Type { get; }
        string Radical { get; }
        int Number { get; }
    }
}
