namespace Wacton.Desu.Tests.Japanese;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

public class TestEntry : IJapaneseEntry
{
    public int Sequence { get; init; }

    public IEnumerable<IKanji> Kanjis { get; init; } = new List<IKanji>();

    public IEnumerable<IReading> Readings { get; init; } = new List<IReading>();

    public IEnumerable<ISense> Senses { get; init; } = new List<ISense>();

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

        stringBuilder.Append(Senses.First().Glosses.First(gloss => gloss.Language.Equals(Language.English)).Term);
        return stringBuilder.ToString();
    }
}