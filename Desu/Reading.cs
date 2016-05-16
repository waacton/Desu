namespace Wacton.Desu
{
    using System.Collections.Generic;

    public class Reading : IReading
    {
        public string Text { get; set; }

        public bool IsTrueKanjiReading { get; set; } = true;

        private readonly List<string> restriction = new List<string>();
        internal List<string> GetRestriction() => this.restriction;
        public IEnumerable<string> Restriction => this.GetRestriction();

        private readonly List<ReadingInformation> informations = new List<ReadingInformation>();
        internal List<ReadingInformation> GetInformations() => this.informations;
        public IEnumerable<ReadingInformation> Informations => this.GetInformations();

        private readonly List<Priority> priorities = new List<Priority>();
        internal List<Priority> GetPriorities() => this.priorities;
        public IEnumerable<Priority> Priorities => this.GetPriorities();

        public override string ToString()
        {
            return this.Text;
        }
    }
}
