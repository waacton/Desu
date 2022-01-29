namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

public class TestTranslation : ITranslation
{
    public IEnumerable<NameType> NameTypes { get; init; } = new List<NameType>();
    public IEnumerable<string> CrossReferences { get; init; } = new List<string>();
    public IEnumerable<string> Transcriptions { get; init; } = new List<string>();

    public override string ToString() => Transcriptions.First();
}