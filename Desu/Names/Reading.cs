namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    internal class Reading : IReading
    {
        public string Text { get; set; }

        public bool IsTrueKanjiReading { get; set; } = true;

        internal readonly List<string> RestrictionList = new List<string>();
        public IEnumerable<string> Restriction => RestrictionList;

        internal readonly List<ReadingInformation> InformationsList = new List<ReadingInformation>();
        public IEnumerable<ReadingInformation> Informations => InformationsList;

        internal readonly List<Priority> PrioritiesList = new List<Priority>();
        public IEnumerable<Priority> Priorities => PrioritiesList;

        public override string ToString() => Text;
    }
}
