namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface ISense
    {
        IEnumerable<string> KanjiRestriction { get; }
        IEnumerable<string> ReadingRestriction { get; }
        IEnumerable<PartOfSpeech> PartsOfSpeech { get; }
        IEnumerable<string> CrossReferences { get; }
        IEnumerable<string> Antonyms { get; }
        IEnumerable<Field> Fields { get; }
        IEnumerable<Miscellaneous> Miscellanea { get; }
        IEnumerable<string> Informations { get; }
        IEnumerable<ILoanwordGloss> LoanwordSources { get; }
        IEnumerable<Dialect> Dialects { get; }
        IEnumerable<IGloss> Glosses { get; }
    }
}
