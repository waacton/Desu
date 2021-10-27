namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class BushuRadicalNelson : IBushuRadical
    {
        public BushuRadicalType Type => BushuRadicalType.Nelson;
        public string Radical => null;
        public int Number { get; }

        public BushuRadicalNelson(int number)
        {
            Number = number;
        }

        public override string ToString() => $"{Type} #{Number}";

        public override bool Equals(object obj)
        {
            return obj is BushuRadicalNelson nelson &&
                   EqualityComparer<BushuRadicalType>.Default.Equals(Type, nelson.Type) &&
                   Radical == nelson.Radical &&
                   Number == nelson.Number;
        }
    }
}