namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class BushuRadicalNelson : IBushuRadical, IEquatable<BushuRadicalNelson>
    {
        public BushuRadicalType Type => BushuRadicalType.Nelson;
        public string Radical => null;
        public int Number { get; }

        public BushuRadicalNelson(int number)
        {
            Number = number;
        }

        public override string ToString() => $"{Type} #{Number}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as BushuRadicalNelson);
        }

        public bool Equals(BushuRadicalNelson other)
        {
            return other != null &&
                   EqualityComparer<BushuRadicalType>.Default.Equals(Type, other.Type) &&
                   Radical == other.Radical &&
                   Number == other.Number;
        }

        public override int GetHashCode()
        {
            int hashCode = 939179138;
            hashCode = hashCode * -1521134295 + EqualityComparer<BushuRadicalType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Radical);
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            return hashCode;
        }
    }
}