using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Enums;
using Wacton.Desu.Kanji;

namespace Wacton.Desu.Tests.Kanji
{
    public class TestEntry : IKanjiEntry
    {
        public string Literal { get; set; }
        public IEnumerable<string> RadicalDecomposition { get; set; } = new List<string>();
        public IEnumerable<ICodepoint> Codepoints { get; set; } = new List<ICodepoint>();
        public IEnumerable<string> StrokePaths { get; set; } = new List<string>();
        public IEnumerable<IBushuRadical> BushuRadicals { get; set; } = new List<IBushuRadical>();
        public bool IsBushuRadical { get; set; } = false;
        public Grade Grade { get; set; } = Grade.None;
        public int StrokeCount { get; set; }
        public IEnumerable<int> StrokeCommonMiscounts { get; set; } = new List<int>();
        public IEnumerable<IVariant> Variants { get; set; } = new List<IVariant>();
        public int? Frequency { get; set; } = null;
        public IEnumerable<string> RadicalNames { get; set; } = new List<string>();
        public int? JLPT { get; set; } = null;
        public IEnumerable<IReference> References { get; set; } = new List<IReference>();
        public IEnumerable<IQueryCode> QueryCodes { get; set; } = new List<IQueryCode>();
        public IEnumerable<IReading> Readings { get; set; } = new List<IReading>();
        public IEnumerable<IMeaning> Meanings { get; set; } = new List<IMeaning>();
        public IEnumerable<string> Nanoris { get; set; } = new List<string>();

        public override string ToString()
        {
            var english = string.Join(" | ", this.Meanings.Where(meaning => meaning.Language.Equals(Language.English)).Select(meaning => meaning.Term));
            return $"{this.Literal}{(string.IsNullOrEmpty(english) ? string.Empty : " | " + english)}";
        }
    }
}
