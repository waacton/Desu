namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    public class BushuRadicalNelson : IBushuRadical
    {
        public BushuRadicalType Type => BushuRadicalType.Nelson;
        public string Radical => null;
        public int Number { get; }

        public BushuRadicalNelson(int number)
        {
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{this.Type} #{this.Number}";
        }

        public override bool Equals(object obj)
        {
            return obj is BushuRadicalNelson nelson &&
                   EqualityComparer<BushuRadicalType>.Default.Equals(Type, nelson.Type) &&
                   Radical == nelson.Radical &&
                   Number == nelson.Number;
        }
    }
}