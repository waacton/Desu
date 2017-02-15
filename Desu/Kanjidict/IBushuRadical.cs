namespace Wacton.Desu.Kanjidict
{
    public interface IBushuRadical
    {
        BushuRadicalType Type { get; }
        
        string Value { get; }
    }
}
