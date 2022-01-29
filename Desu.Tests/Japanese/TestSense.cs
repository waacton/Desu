namespace Wacton.Desu.Tests.Japanese;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

public class TestSense : ISense
{
    public IEnumerable<string> KanjiRestriction { get; init; } = new List<string>();
    public IEnumerable<string> ReadingRestriction { get; init; } = new List<string>();
    public IEnumerable<PartOfSpeech> PartsOfSpeech { get; init; } = new List<PartOfSpeech>();
    public IEnumerable<string> CrossReferences { get; init; } = new List<string>();
    public IEnumerable<string> Antonyms { get; init; } = new List<string>();
    public IEnumerable<Field> Fields { get; init; } = new List<Field>();
    public IEnumerable<Miscellaneous> Miscellanea { get; init; } = new List<Miscellaneous>();
    public IEnumerable<string> Informations { get; init; } = new List<string>();
    public IEnumerable<ILoanwordGloss> LoanwordSources { get; init; } = new List<LoanwordGloss>();
    public IEnumerable<Dialect> Dialects { get; init; } = new List<Dialect>();
    public IEnumerable<IGloss> Glosses { get; init; } = new List<Gloss>();

    public override string ToString() => Glosses.First().ToString();
}