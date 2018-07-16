namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    public class Sense : ISense
    {
        private readonly List<string> kanjiRestriction = new List<string>();
        public List<string> GetKanjiRestriction() => this.kanjiRestriction; 
        public IEnumerable<string> KanjiRestriction => this.GetKanjiRestriction();

        private readonly List<string> readingRestriction = new List<string>();
        public List<string> GetReadingRestriction() => this.readingRestriction;
        public IEnumerable<string> ReadingRestriction => this.GetReadingRestriction();

        private readonly List<PartOfSpeech> partsOfSpeech = new List<PartOfSpeech>();
        public List<PartOfSpeech> GetPartsOfSpeech() => this.partsOfSpeech;
        public IEnumerable<PartOfSpeech> PartsOfSpeech => this.GetPartsOfSpeech();

        private readonly List<string> crossReferences = new List<string>();
        public List<string> GetCrossReferences() => this.crossReferences;
        public IEnumerable<string> CrossReferences => this.GetCrossReferences();

        private readonly List<string> antonyms = new List<string>();
        public List<string> GetAntonyms() => this.antonyms;
        public IEnumerable<string> Antonyms => this.GetAntonyms();

        private readonly List<Field> fields = new List<Field>();
        public List<Field> GetFields() => this.fields;
        public IEnumerable<Field> Fields => this.GetFields();

        private readonly List<Miscellaneous> miscellanea = new List<Miscellaneous>();
        public List<Miscellaneous> GetMiscellanea() => this.miscellanea;
        public IEnumerable<Miscellaneous> Miscellanea => this.GetMiscellanea();

        private readonly List<string> informations = new List<string>();
        public List<string> GetInformations() => this.informations;
        public IEnumerable<string> Informations => this.GetInformations();

        private readonly List<LoanwordGloss> loanwordSources = new List<LoanwordGloss>();
        public List<LoanwordGloss> GetLoanwordSources() => this.loanwordSources;
        public IEnumerable<LoanwordGloss> LoanwordSources => this.GetLoanwordSources();

        private readonly List<Dialect> dialects = new List<Dialect>();
        public List<Dialect> GetDialects() => this.dialects;
        public IEnumerable<Dialect> Dialects => this.GetDialects();

        private readonly List<Gloss> glosses = new List<Gloss>();
        public List<Gloss> GetGlosses() => this.glosses;
        public IEnumerable<Gloss> Glosses => this.GetGlosses();

        public override string ToString()
        {
            return this.Glosses.First().ToString();
        }
    }
}
