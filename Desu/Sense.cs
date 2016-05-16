namespace Wacton.Desu
{
    using System.Collections.Generic;
    using System.Linq;

    public class Sense : ISense
    {
        private readonly List<string> kanjiRestriction = new List<string>();
        internal List<string> GetKanjiRestriction() => this.kanjiRestriction; 
        public IEnumerable<string> KanjiRestriction => this.GetKanjiRestriction();

        private readonly List<string> readingRestriction = new List<string>();
        internal List<string> GetReadingRestriction() => this.readingRestriction;
        public IEnumerable<string> ReadingRestriction => this.GetReadingRestriction();

        private readonly List<PartOfSpeech> partsOfSpeech = new List<PartOfSpeech>();
        internal List<PartOfSpeech> GetPartsOfSpeech() => this.partsOfSpeech;
        public IEnumerable<PartOfSpeech> PartsOfSpeech => this.GetPartsOfSpeech();

        private readonly List<string> crossReferences = new List<string>();
        internal List<string> GetCrossReferences() => this.crossReferences;
        public IEnumerable<string> CrossReferences => this.GetCrossReferences();

        private readonly List<string> antonyms = new List<string>();
        internal List<string> GetAntonyms() => this.antonyms;
        public IEnumerable<string> Antonyms => this.GetAntonyms();

        private readonly List<Field> fields = new List<Field>();
        internal List<Field> GetFields() => this.fields;
        public IEnumerable<Field> Fields => this.GetFields();

        private readonly List<Miscellaneous> miscellanea = new List<Miscellaneous>();
        internal List<Miscellaneous> GetMiscellanea() => this.miscellanea;
        public IEnumerable<Miscellaneous> Miscellanea => this.GetMiscellanea();

        private readonly List<string> informations = new List<string>();
        internal List<string> GetInformations() => this.informations;
        public IEnumerable<string> Informations => this.GetInformations();

        private readonly List<LoanwordGloss> loanwordSources = new List<LoanwordGloss>();
        internal List<LoanwordGloss> GetLoanwordSources() => this.loanwordSources;
        public IEnumerable<LoanwordGloss> LoanwordSources => this.GetLoanwordSources();

        private readonly List<Dialect> dialects = new List<Dialect>();
        internal List<Dialect> GetDialects() => this.dialects;
        public IEnumerable<Dialect> Dialects => this.GetDialects();

        private readonly List<Gloss> glosses = new List<Gloss>();
        internal List<Gloss> GetGlosses() => this.glosses;
        public IEnumerable<Gloss> Glosses => this.GetGlosses();

        public override string ToString()
        {
            return this.Glosses.First(gloss => gloss.Language.Equals(Language.English)).ToString();
        }
    }
}
