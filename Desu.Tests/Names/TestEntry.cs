namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Names;

public class TestEntry : INameEntry
{
    public int Sequence { get; init; }

    public IEnumerable<IKanji> Kanjis { get; init; } = new List<IKanji>();

    public IEnumerable<IReading> Readings { get; init; } = new List<IReading>();

    public IEnumerable<ITranslation> Translations { get; init; } = new List<ITranslation>();

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"#{Sequence} :: ");

        foreach (var kanji in Kanjis)
        {
            stringBuilder.Append(kanji.Text + " · ");
        }

        foreach (var reading in Readings)
        {
            stringBuilder.Append(reading.Text + " · ");
        }

        stringBuilder.Append(Translations.First());
        return stringBuilder.ToString();
    }
}