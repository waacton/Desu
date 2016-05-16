namespace Wacton.Desu
{
    using System.Collections.Generic;

    public class Kanji : IKanji
    {
        public string Text { get; set; }

        private readonly List<KanjiInformation> informations = new List<KanjiInformation>();
        internal List<KanjiInformation> GetInformations() => this.informations;
        public IEnumerable<KanjiInformation> Informations => this.GetInformations();

        private readonly List<Priority> priorities = new List<Priority>();
        internal List<Priority> GetPriorities() => this.priorities;
        public IEnumerable<Priority> Priorities => this.GetPriorities();

        public override string ToString()
        {
            return this.Text;
        }
    }
}