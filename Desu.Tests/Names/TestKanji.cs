namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

public class TestKanji : IKanji
{
    public string Text { get; init; }
    public IEnumerable<KanjiInformation> Informations { get; init; } = new List<KanjiInformation>();
    public IEnumerable<Priority> Priorities { get; init; } = new List<Priority>();

    public override string ToString() => Text;
}