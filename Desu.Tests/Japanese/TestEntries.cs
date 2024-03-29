﻿namespace Wacton.Desu.Tests.Japanese;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

public static class TestEntries
{
    public static TestEntry 食べる()
    {
        var kanji1 = new TestKanji
        {
            Text = "食べる",
            Priorities = new List<Priority> { Priority("ichi1"), Priority("news2"), Priority("nf25") }
        };

        var kanji2 = new TestKanji
        {
            Text = "喰べる",
            Informations = new List<KanjiInformation> { KanjiInformation("word containing irregular kanji usage") }
        };

        var reading1 = new TestReading
        {
            Text = "たべる",
            Priorities = new List<Priority> { Priority("ichi1"), Priority("news2"), Priority("nf25") }
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("Ichidan verb"), PartOfSpeech("transitive verb") },
            Glosses = new List<Gloss> { new("to eat", Language("eng"), null, null) }
        };

        var sense2 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("Ichidan verb"), PartOfSpeech("transitive verb") },
            Glosses = new List<Gloss> {
                new("to live on (e.g. a salary)", Language("eng"), null, null),
                new("to live off", Language("eng"), null, null),
                new("to subsist on", Language("eng"), null, null),
            }
        };

        var sense3 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("eten", Language("dut"), null, null),
                new("opeten", Language("dut"), null, null),
                new("consumeren", Language("dut"), null, null),
                new("gebruiken", Language("dut"), null, null),
                new("nemen", Language("dut"), null, null),
                new("nuttigen", Language("dut"), null, null),
                new("verorberen", Language("dut"), null, null),
                new("naar binnen werken", Language("dut"), null, null),
                new("wegwerken", Language("dut"), null, null),
                new("{inform.} bikken", Language("dut"), null, null),
                new("{inform.} binnenslaan", Language("dut"), null, null),
                new("{i.h.b.} zich voeden met", Language("dut"), null, null),
                new("{uitdr.} de inwendige mens versterken", Language("dut"), null, null)
            }
        };

        var sense4 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("de kost verdienen", Language("dut"), null, null),
                new("aan de kost komen", Language("dut"), null, null),
                new("in zijn onderhoud voorzien", Language("dut"), null, null),
                new("leven (van)", Language("dut"), null, null)
            }
        };

        var sense5 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("manger", Language("fre"), null, null)
            }
        };

        var sense6 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("vivre avec (par ex. un salaire)", Language("fre"), null, null),
                new("vivre de (par ex. ses rentes)", Language("fre"), null, null),
                new("subsister grâce à", Language("fre"), null, null)
            }
        };

        var sense7 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("essen", Language("ger"), null, null),
                new("speisen", Language("ger"), null, null),
                new("zu sich nehmen", Language("ger"), null, null),
                new("fressen", Language("ger"), null, null),
                new("probieren", Language("ger"), null, null),
            }
        };

        var sense8 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("leben von", Language("ger"), null, null),
            }
        };

        var sense9 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("kiesz", Language("hun"), null, null),
            }
        };

        var sense10 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("1) есть", Language("rus"), null, null),
                new("2) (перен.) жить, существовать", Language("rus"), null, null),
            }
        };

        var sense11 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("jesti", Language("slv"), null, null),
            }
        };

        var sense12 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("comer", Language("spa"), null, null),
            }
        };

        var sense13 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("äta", Language("swe"), null, null),
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1358280,
            Kanjis = new List<IKanji> { kanji1, kanji2 },
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1, sense2, sense3, sense4, sense5, sense6, sense7, sense8, sense9, sense10, sense11, sense12, sense13 }
        };

        return testEntry;
    }

    public static TestEntry 々()
    {
        var kanji1 = new TestKanji
        {
            Text = "々"
        };

        var reading1 = new TestReading
        {
            Text = "のま"
        };

        var reading2 = new TestReading
        {
            Text = "ノマ",
            IsTrueKanjiReading = false
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("unclassified") },
            CrossReferences = new List<string> { "同の字点" },
            Glosses = new List<Gloss> { new("kanji repetition mark", Language("eng"), GlossType("expl"), null) }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("teken dat herhaling van de voorafgaande kanji aanduidt; ook dō no jiten 同の字点 genoemd", Language("dut"), null, null),
            }
        };

        var sense3 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("Wiederholungszeichen für Kanji (Laut wird durch Wiederholung manchmal stimmhaft)", Language("ger"), null, null)
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1000060,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1, reading2 },
            Senses = new List<ISense> { sense1, sense2, sense3 }
        };

        return testEntry;
    }

    public static TestEntry βカロテン()
    {
        var kanji1 = new TestKanji
        {
            Text = "βカロテン"
        };

        var kanji2 = new TestKanji
        {
            Text = "βカロチン",
        };

        var kanji3 = new TestKanji
        {
            Text = "β-カロテン",
        };

        var kanji4 = new TestKanji
        {
            Text = "β-カロチン",
        };

        var reading1 = new TestReading
        {
            Text = "ベータカロテン",
            Restriction = new List<string> { "βカロテン", "β-カロテン" }
        };

        var reading2 = new TestReading
        {
            Text = "ベータカロチン",
            Restriction = new List<string> { "βカロチン", "β-カロチン" }
        };

        var reading3 = new TestReading
        {
            Text = "ベタカロテン",
            Restriction = new List<string> { "βカロテン", "β-カロテン" },
            Informations = new List<ReadingInformation> { ReadingInformation("word containing irregular kana usage") }
        };

        var reading4 = new TestReading
        {
            Text = "ベタカロチン",
            Restriction = new List<string> { "βカロチン", "β-カロチン" },
            Informations = new List<ReadingInformation> { ReadingInformation("word containing irregular kana usage") }
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Glosses = new List<Gloss> { new("beta-carotene", Language("eng"), null, null) }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1149580,
            Kanjis = new List<IKanji> { kanji1, kanji2, kanji3, kanji4 },
            Readings = new List<IReading> { reading1, reading2, reading3, reading4 },
            Senses = new List<ISense> { sense1 }
        };

        return testEntry;
    }

    public static TestEntry Withコロナ()
    {
        var kanji1 = new TestKanji
        {
            Text = "ｗｉｔｈコロナ"
        };

        var reading1 = new TestReading
        {
            Text = "ウィズコロナ",
        };
            
        var reading2 = new TestReading
        {
            Text = "ウイズコロナ",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Miscellanea = new List<Miscellaneous> { Miscellaneous("word usually written using kana alone") },
            LoanwordSources = new List<LoanwordGloss> { new("with corona", Language("eng"), null, null, false, true) },
            Glosses = new List<Gloss> {
                new("coexisting with the coronavirus", Language("eng"), null, null),
                new("life during the COVID-19 pandemic", Language("eng"), null, null)
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 2845709,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1, reading2 },
            Senses = new List<ISense> { sense1 }
        };

        return testEntry;
    }

    public static TestEntry サーターアンダギー()
    {
        var reading1 = new TestReading
        {
            Text = "サーターアンダギー",
        };

        var reading2 = new TestReading
        {
            Text = "サーターアンダーギー",
        };

        var reading3 = new TestReading
        {
            Text = "サータアンダーギー",
        };

        var reading4 = new TestReading
        {
            Text = "さーたーあんだぎー",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Fields = new List<Field> { Field("food, cooking") },
            Dialects = new List<Dialect> { Dialect("Ryuukyuu-ben") },
            Glosses = new List<Gloss> {
                new("sata andagi", Language("eng"), null, null),
                new("Okinawan sweet deep-fried bun similar to a doughnut", Language("eng"), GlossType("expl"), null)
            }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("Sātāandagī", Language("ger"), null, null),
                new("okinawaisches Schmalzgebackenes", Language("ger"), null, null)
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1985540,
            Readings = new List<IReading> { reading1, reading2, reading3, reading4 },
            Senses = new List<ISense> { sense1, sense2 }
        };

        return testEntry;
    }

    public static TestEntry 九百()
    {
        var kanji1 = new TestKanji
        {
            Text = "９００",
        };

        var kanji2 = new TestKanji
        {
            Text = "九百",
        };

        var kanji3 = new TestKanji
        {
            Text = "９百",
        };

        var kanji4 = new TestKanji
        {
            Text = "九〇〇",
        };

        var reading1 = new TestReading
        {
            Text = "きゅうひゃく",
        };

        var reading2 = new TestReading
        {
            Text = "くひゃく",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("numeric") },
            Glosses = new List<Gloss> {
                new("900", Language("eng"), null, null),
                new("nine hundred", Language("eng"), null, null)
            }
        };

        var sense2 = new TestSense
        {
            KanjiRestriction = new List<string> { "九百" },
            ReadingRestriction = new List<string> { "くひゃく" },
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Miscellanea = new List<Miscellaneous> { Miscellaneous("archaic"), Miscellaneous("derogatory") },
            Glosses = new List<Gloss> {
                new("fool", Language("eng"), null, null),
                new("idiot", Language("eng"), null, null)
            }
        };

        var sense3 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("neunhundert", Language("ger"), null, null),
                new("900", Language("ger"), null, null)
            }
        };

        var sense4 = new TestSense
        {
            Glosses = new List<Gloss> { new("девятьсот", Language("rus"), null, null) }
        };

        var sense5 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("novecientos", Language("spa"), null, null),
                new("900", Language("spa"), null, null)
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 2220410,
            Kanjis = new List<IKanji> { kanji1, kanji2, kanji3, kanji4 },
            Readings = new List<IReading> { reading1, reading2 },
            Senses = new List<ISense> { sense1, sense2, sense3, sense4, sense5 }
        };

        return testEntry;
    }
        
    public static TestEntry 蘇格蘭()
    {
        var kanji1 = new TestKanji
        {
            Text = "蘇格蘭",
            Informations = new List<KanjiInformation> {
                KanjiInformation("ateji (phonetic) reading"),
                KanjiInformation("rarely-used kanji form")
            }
        };
            
        var reading1 = new TestReading
        {
            Text = "スコットランド",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Miscellanea = new List<Miscellaneous> { Miscellaneous("word usually written using kana alone") },
            Glosses = new List<Gloss> { new("Scotland", Language("eng"), null, null) }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("Schotland", Language("dut"), null, null),
                new("{afk.} Sch.", Language("dut"), null, null)
            }
        };

        var sense3 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("Schottland (Nordteil Großbritanniens einschl. der Hebriden, Orkney- und Shetland-Inseln)", Language("ger"), null, null),
            }
        };

        var sense4 = new TestSense
        {
            Glosses = new List<Gloss> { new("Шотландия", Language("rus"), null, null) }
        };

        var sense5 = new TestSense
        {
            Glosses = new List<Gloss> { new("escocia", Language("spa"), null, null) }
        };
            
        var sense6 = new TestSense
        {
            Glosses = new List<Gloss> { new("Skottland", Language("swe"), null, null) }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1069140,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1, sense2, sense3, sense4, sense5, sense6 }
        };

        return testEntry;
    }
        
    public static TestEntry 羊水()
    {
        var kanji1 = new TestKanji
        {
            Text = "羊水",
            Priorities = new List<Priority> { Priority("news2"), Priority("nf33") }
        };
            
        var reading1 = new TestReading
        {
            Text = "ようすい",
            Priorities = new List<Priority> { Priority("news2"), Priority("nf33") }
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            Fields = new List<Field> { Field("pathology") },
            Glosses = new List<Gloss> { new("amniotic fluid", Language("eng"), null, null) }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("Fruchtwasser", Language("ger"), null, null),
                new("Amnionflüssigkeit", Language("ger"), null, null),
                new("Liquor amnii", Language("ger"), null, null)
            }
        };

        var sense3 = new TestSense
        {
            Glosses = new List<Gloss> {
                new("fostervatten", Language("swe"), null, null),
            }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1662330,
            Kanjis = new List<IKanji> { kanji1 },
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1, sense2, sense3 }
        };

        return testEntry;
    }

    public static TestEntry タチ()
    {
        var reading1 = new TestReading
        {
            Text = "タチ",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            CrossReferences = new List<string> { "攻め・2", "受け・5" },
            Antonyms = new List<string> { "猫・6" },
            Miscellanea = new List<Miscellaneous> { Miscellaneous("colloquial") },
            Glosses = new List<Gloss> { new("dominant partner of a homosexual relationship", Language("eng"), null, null) }
        };

        var testEntry = new TestEntry
        {
            Sequence = 2180730,
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1 }
        };

        return testEntry;
    }

    public static TestEntry コンビナートキャンペーン()
    {
        var reading1 = new TestReading
        {
            Text = "コンビナートキャンペーン",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("noun (common) (futsuumeishi)") },
            LoanwordSources = new List<LoanwordGloss> { 
                new("kombinat", Language("rus"), null, null, true, false),
                new("campaign", Language("eng"), null, null, true, false)
            },
            Glosses = new List<Gloss> { new("industrial campaign", Language("eng"), null, null) }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> { new("industrieübergreifende Werbekampagne", Language("ger"), null, null) }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1053260,
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1, sense2 }
        };

        return testEntry;
    }

    public static TestEntry ヽ()
    {
        var reading1 = new TestReading
        {
            Text = "ヽ",
        };

        var sense1 = new TestSense
        {
            PartsOfSpeech = new List<PartOfSpeech> { PartOfSpeech("unclassified") },
            CrossReferences = new List<string> { "一の字点" },
            Glosses = new List<Gloss> { new("repetition mark in katakana", Language("eng"), GlossType("expl"), null) }
        };

        var sense2 = new TestSense
        {
            Glosses = new List<Gloss> { new("hitotsuten 一つ点: teken dat herhaling van het voorafgaande katakana-schriftteken aangeeft", Language("dut"), null, null) }
        };

        var testEntry = new TestEntry
        {
            Sequence = 1000000,
            Readings = new List<IReading> { reading1 },
            Senses = new List<ISense> { sense1, sense2 }
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
                    Informations = new []{ Enums.KanjiInformation.RarelyUsedKanji },
                    Priorities = new []{ Enums.Priority.SpecialCommon2 }
                }
            },
            Readings = new []
            {
                new TestReading
                {
                    Text = null,
                    IsTrueKanjiReading = true,
                    Restriction = new []{"[Restriction]"},
                    Informations = new []{ Enums.ReadingInformation.OutdatedKana },
                    Priorities = new []{ Enums.Priority.SpecialCommon2 }
                }
            },
            Senses = new []
            {
                new TestSense
                {
                    KanjiRestriction = new []{ "[KanjiRestriction]" },
                    ReadingRestriction = new []{ "[ReadingRestriction]" },
                    PartsOfSpeech = new []{ Enums.PartOfSpeech.VerbUnspecified },
                    CrossReferences = new []{ "[CrossReference]" },
                    Antonyms = new []{ "[Antonym]" },
                    Fields = new []{ Enums.Field.Zoology },
                    Miscellanea = new []{ Enums.Miscellaneous.Yojijukugo },
                    Informations = new []{ "[Information]" },
                    LoanwordSources = new[] { new LoanwordGloss("term", Enums.Language.Yiddish, Enums.GlossType.Trademark, "gender", true, true) },
                    Dialects = new []{ Enums.Dialect.Tsugaru },
                    Glosses = new []{ new Gloss("term", Enums.Language.English, Enums.GlossType.Trademark, "gender") }
                }
            }
        };
    }

    private static Dialect Dialect(string code) => Enumeration.GetAll<Dialect>().Single(x => x.Code == code);
    private static Field Field(string code) => Enumeration.GetAll<Field>().Single(x => x.Code == code);
    private static GlossType GlossType(string code) => Enumeration.GetAll<GlossType>().Single(x => x.Code == code);
    private static Language Language(string code) => Enumeration.GetAll<Language>().Single(x => x.ThreeLetterCode == code);
    private static KanjiInformation KanjiInformation(string code) => Enumeration.GetAll<KanjiInformation>().Single(x => x.Code == code);
    private static Miscellaneous Miscellaneous(string code) => Enumeration.GetAll<Miscellaneous>().Single(x => x.Code == code);
    private static PartOfSpeech PartOfSpeech(string code) => Enumeration.GetAll<PartOfSpeech>().Single(x => x.Code == code);
    private static Priority Priority(string code) => Enumeration.GetAll<Priority>().Single(x => x.Code == code);
    private static ReadingInformation ReadingInformation(string code) => Enumeration.GetAll<ReadingInformation>().Single(x => x.Code == code);
}