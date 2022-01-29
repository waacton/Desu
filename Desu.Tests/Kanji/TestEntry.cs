namespace Wacton.Desu.Tests.Kanji;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Kanji;

public class TestEntry : IKanjiEntry
{
    public string Literal { get; init; }
    public IEnumerable<string> RadicalDecomposition { get; init; } = new List<string>();
    public IEnumerable<ICodepoint> Codepoints { get; init; } = new List<ICodepoint>();
    public IEnumerable<string> StrokePaths { get; init; } = new List<string>();
    public IEnumerable<IIndexRadical> IndexRadicals { get; init; } = new List<IIndexRadical>();
    public bool IsIndexRadical { get; init; } = false;
    public Grade Grade { get; init; } = Grade.None;
    public int StrokeCount { get; init; }
    public IEnumerable<int> StrokeCommonMiscounts { get; init; } = new List<int>();
    public IEnumerable<IVariant> Variants { get; init; } = new List<IVariant>();
    public int? Frequency { get; init; } = null;
    public IEnumerable<string> RadicalNames { get; init; } = new List<string>();
    public int? JLPT { get; init; } = null;
    public IEnumerable<IReference> References { get; init; } = new List<IReference>();
    public IEnumerable<IQueryCode> QueryCodes { get; init; } = new List<IQueryCode>();
    public IEnumerable<IReading> Readings { get; init; } = new List<IReading>();
    public IEnumerable<IMeaning> Meanings { get; init; } = new List<IMeaning>();
    public IEnumerable<string> Nanoris { get; init; } = new List<string>();

    public override string ToString()
    {
        var english = string.Join(" · ", Meanings.Where(meaning => meaning.Language.Equals(Language.English)).Select(meaning => meaning.Term));
        return $"{Literal}{(string.IsNullOrEmpty(english) ? string.Empty : " · " + english)}";
    }
}