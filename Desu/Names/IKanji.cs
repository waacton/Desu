namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    // TODO: Informations & Priorities are only used in Japanese dictionary (not Name dictionary)
    // - consider either removing them, or merging the two IKanji objects together
    public interface IKanji
    {
        string Text { get; }
        IEnumerable<KanjiInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
