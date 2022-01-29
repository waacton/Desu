namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

public static class TestEntries
{
    public static TestEntry 国語研究所()
    {
        var kanji1 = new TestKanji
        {
            Text = "国語研究所"
        };

        var reading1 = new TestReading
        {
            Text = "こくごけんきゅうじょ"
        };

        var translation1 = new TestTranslation
        {
            NameTypes = new List<NameType> { NameType("organization name") },
            CrossReferences = new List<string> { "国立国語研究所" },
            Transcriptions = new List<string> { "National Institute for Japanese Language and Linguistics", "NINJAL", "Kokken" }
        };

        var testEntry = new TestEntry
        {
            Sequence = 5294339,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1 },
            Translations = new List<ITranslation> { translation1 }
        };

        return testEntry;
    }

    public static TestEntry ガラパゴス()
    {
        var reading1 = new TestReading
        {
            Text = "ガラパゴス"
        };

        var translation1 = new TestTranslation
        {
            NameTypes = new List<NameType> { NameType("place name") },
            Transcriptions = new List<string> { "Galapagos (island chain)" }
        };

        var translation2 = new TestTranslation
        {
            NameTypes = new List<NameType> { NameType("product name") },
            Transcriptions = new List<string> { "Sharp brand of e-readers and mobile phones" }
        };

        var testEntry = new TestEntry
        {
            Sequence = 5024564,
            Readings = new List<IReading> { reading1 },
            Translations = new List<ITranslation> { translation1, translation2 }
        };

        return testEntry;
    }

    public static TestEntry 国労()
    {
        var kanji1 = new TestKanji
        {
            Text = "国労"
        };

        var reading1 = new TestReading
        {
            Text = "こくろう"
        };

        var translation1 = new TestTranslation
        {
            NameTypes = new List<NameType> { NameType("organization name") },
            Transcriptions = new List<string> { "National Railway Workers' Union" }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1657560,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1 },
            Translations = new List<ITranslation> { translation1 }
        };

        return testEntry;
    }
        
    public static TestEntry FullObject()
    {
        return new TestEntry
        {
            Sequence = 999999999,
            Kanjis = new []
            {
                new TestKanji
                {
                    Text = null,
                    Informations = new []{ KanjiInformation.RarelyUsedKanji },
                    Priorities = new []{ Priority.SpecialCommon2 }
                }
            },
            Readings = new []
            {
                new TestReading
                {
                    Text = null,
                    Restriction = new []{"[Restriction]"},
                    Informations = new []{ ReadingInformation.OutdatedKana },
                    Priorities = new []{ Priority.SpecialCommon2 }
                }
            },
            Translations = new []
            {
                new TestTranslation
                {
                    NameTypes = new []{ Enums.NameType.Work },
                    CrossReferences = new []{ "[CrossReference]" },
                    Transcriptions = new []{ "[Transcription]" }
                }
            }
        };
    }

    private static NameType NameType(string code) => Enumeration.GetAll<NameType>().Single(x => x.Code == code);
}