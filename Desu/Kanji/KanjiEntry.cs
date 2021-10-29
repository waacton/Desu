namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    internal class KanjiEntry : IKanjiEntry
    {
        public string Literal { get; set; }

        internal readonly List<string> RadicalDecompositionList = new List<string>();
        public IEnumerable<string> RadicalDecomposition => RadicalDecompositionList;

        internal readonly List<Codepoint> CodepointsList = new List<Codepoint>();
        public IEnumerable<ICodepoint> Codepoints => CodepointsList;

        internal readonly List<string> StrokePathsList = new List<string>();
        public IEnumerable<string> StrokePaths => StrokePathsList;

        internal readonly List<IIndexRadical> IndexRadicalsList = new List<IIndexRadical>();
        public IEnumerable<IIndexRadical> IndexRadicals => IndexRadicalsList;

        public bool IsIndexRadical => IndexRadicalsList.Single(radical => radical.Type.Equals(IndexRadicalType.Kangxi)).Radical.Equals(Literal);

        public Grade Grade { get; set; } = Grade.None;

        public int StrokeCount { get; set; }

        internal readonly List<int> StrokeCommonMiscountsList = new List<int>();
        public IEnumerable<int> StrokeCommonMiscounts => StrokeCommonMiscountsList;

        internal readonly List<Variant> VariantsList = new List<Variant>();
        public IEnumerable<IVariant> Variants => VariantsList;

        public int? Frequency { get; set; }

        internal readonly List<string> RadicalNamesList = new List<string>();
        public IEnumerable<string> RadicalNames => RadicalNamesList;

        public int? JLPT { get; set; }

        internal readonly List<Reference> ReferencesList = new List<Reference>();
        public IEnumerable<IReference> References => ReferencesList;

        internal readonly List<QueryCode> QueryCodesList = new List<QueryCode>();
        public IEnumerable<IQueryCode> QueryCodes => QueryCodesList;

        internal readonly List<Reading> ReadingsList = new List<Reading>();
        public IEnumerable<IReading> Readings => ReadingsList;

        internal readonly List<Meaning> MeaningsList = new List<Meaning>();
        public IEnumerable<IMeaning> Meanings => MeaningsList;

        internal readonly List<string> NanorisList = new List<string>();
        public IEnumerable<string> Nanoris => NanorisList;

        public override string ToString()
        {
            var english = string.Join(" · ", Meanings.Where(meaning => meaning.Language.Equals(Language.English)).Select(meaning => meaning.Term));
            return $"{Literal}{(string.IsNullOrEmpty(english) ? string.Empty : " · " + english)}";
        }
    }
}