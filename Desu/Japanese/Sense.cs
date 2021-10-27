namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    internal class Sense : ISense
    {
        internal readonly List<string> KanjiRestrictionList = new List<string>();
        public IEnumerable<string> KanjiRestriction => KanjiRestrictionList;

        internal readonly List<string> ReadingRestrictionList = new List<string>();
        public IEnumerable<string> ReadingRestriction => ReadingRestrictionList;

        internal readonly List<PartOfSpeech> PartsOfSpeechList = new List<PartOfSpeech>();
        public IEnumerable<PartOfSpeech> PartsOfSpeech => PartsOfSpeechList;

        internal readonly List<string> CrossReferencesList = new List<string>();
        public IEnumerable<string> CrossReferences => CrossReferencesList;

        internal readonly List<string> AntonymsList = new List<string>();
        public IEnumerable<string> Antonyms => AntonymsList;

        internal readonly List<Field> FieldsList = new List<Field>();
        public IEnumerable<Field> Fields => FieldsList;

        internal readonly List<Miscellaneous> MiscellaneaList = new List<Miscellaneous>();
        public IEnumerable<Miscellaneous> Miscellanea => MiscellaneaList;

        internal readonly List<string> InformationsList = new List<string>();
        public IEnumerable<string> Informations => InformationsList;

        internal readonly List<LoanwordGloss> LoanwordSourcesList = new List<LoanwordGloss>();
        public IEnumerable<ILoanwordGloss> LoanwordSources => LoanwordSourcesList;

        internal readonly List<Dialect> DialectsList = new List<Dialect>();
        public IEnumerable<Dialect> Dialects => DialectsList;

        internal readonly List<Gloss> GlossesList = new List<Gloss>();
        public IEnumerable<IGloss> Glosses => GlossesList;

        public override string ToString() => Glosses.First().ToString();
    }
}
