namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

public class TestReading : IReading
{
    public string Text { get; init; }
    public IEnumerable<string> Restriction { get; init; } = new List<string>();
    public IEnumerable<ReadingInformation> Informations { get; init; } = new List<ReadingInformation>();
    public IEnumerable<Priority> Priorities { get; init; } = new List<Priority>();

    public override string ToString() => Text;
}