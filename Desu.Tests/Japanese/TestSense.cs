using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests.Japanese
{
    public class TestSense : ISense
    {
        public IEnumerable<string> KanjiRestriction { get; set; } = new List<string>();
        public IEnumerable<string> ReadingRestriction { get; set; } = new List<string>();
        public IEnumerable<PartOfSpeech> PartsOfSpeech { get; set; } = new List<PartOfSpeech>();
        public IEnumerable<string> CrossReferences { get; set; } = new List<string>();
        public IEnumerable<string> Antonyms { get; set; } = new List<string>();
        public IEnumerable<Field> Fields { get; set; } = new List<Field>();
        public IEnumerable<Miscellaneous> Miscellanea { get; set; } = new List<Miscellaneous>();
        public IEnumerable<string> Informations { get; set; } = new List<string>();
        public IEnumerable<ILoanwordGloss> LoanwordSources { get; set; } = new List<LoanwordGloss>();
        public IEnumerable<Dialect> Dialects { get; set; } = new List<Dialect>();
        public IEnumerable<IGloss> Glosses { get; set; } = new List<Gloss>();

        public override string ToString() => Glosses.First().ToString();
    }
}
