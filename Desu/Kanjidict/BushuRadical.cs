namespace Wacton.Desu.Kanjidict
{
    public class BushuRadical : IBushuRadical
    {
        public BushuRadicalType Type { get; }

        public string Value { get; }

        public BushuRadical(BushuRadicalType bushuRadicalType, string value)
        {
            this.Type = bushuRadicalType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }
    }
}