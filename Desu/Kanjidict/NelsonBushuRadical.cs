namespace Wacton.Desu.Kanjidict
{
    public class NelsonBushuRadical : IBushuRadical
    {
        public BushuRadicalType Type => BushuRadicalType.Nelson;
        public int Number { get; }

        public NelsonBushuRadical(int number)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{this.Type} #{this.Number}";
        }
    }
}