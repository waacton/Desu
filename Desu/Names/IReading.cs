namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    // TODO: Restriction, Informations & Priorities are only used in Japanese dictionary (not Name dictionary)
    // - consider either removing them, or merging the two IReading objects together
    public interface IReading
    {
        string Text { get; }
        IEnumerable<string> Restriction { get; }
        IEnumerable<ReadingInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
