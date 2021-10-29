namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class IndexRadicalNelson : IIndexRadical, IEquatable<IndexRadicalNelson>
    {
        public IndexRadicalType Type => IndexRadicalType.Nelson;
        public string Radical => null;
        public int Number { get; }

        public IndexRadicalNelson(int number)
        {
            Number = number;
        }

        public override string ToString() => $"{Type} #{Number}";

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as IndexRadicalNelson);
        }

        public bool Equals(IndexRadicalNelson other)
        {
            return other != null &&
                   EqualityComparer<IndexRadicalType>.Default.Equals(Type, other.Type) &&
                   Radical == other.Radical &&
                   Number == other.Number;
        }

        public override int GetHashCode()
        {
            int hashCode = 939179138;
            hashCode = hashCode * -1521134295 + EqualityComparer<IndexRadicalType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Radical);
            hashCode = hashCode * -1521134295 + Number.GetHashCode();
            return hashCode;
        }
    }
}