namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Kanji : IKanji
    {
        public string Text { get; set; }

        private readonly List<KanjiInformation> informations = new List<KanjiInformation>();
        public List<KanjiInformation> GetInformations() => this.informations;
        public IEnumerable<KanjiInformation> Informations => this.GetInformations();

        private readonly List<Priority> priorities = new List<Priority>();
        public List<Priority> GetPriorities() => this.priorities;
        public IEnumerable<Priority> Priorities => this.GetPriorities();

        public override string ToString()
        {
            return this.Text;
        }
    }
}