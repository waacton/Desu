namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Kanji : IKanji
    {
        public string Text { get; set; }

        internal readonly List<KanjiInformation> InformationsList = new List<KanjiInformation>();
        public IEnumerable<KanjiInformation> Informations => InformationsList;

        internal readonly List<Priority> PrioritiesList = new List<Priority>();
        public IEnumerable<Priority> Priorities => PrioritiesList;

        public override string ToString() => Text;
    }
}