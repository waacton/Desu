namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class NelsonBushuRadical : IBushuRadical
    {
        public BushuRadicalType Type => BushuRadicalType.Nelson;
        public string Radical => null;
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