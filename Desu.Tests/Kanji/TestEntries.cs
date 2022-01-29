namespace Wacton.Desu.Tests.Kanji;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Kanji;

public static class TestEntries
{
    public static TestEntry 䯂()
    {
        return new TestEntry
        {
            Literal = "䯂",
            Codepoints = new List<Codepoint> { 
                new(CodepointType("ucs"), "4BC2"), 
                new(CodepointType("jis213"), "2-93-06") 
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(187) },
            StrokeCount = 34,
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "2-30-4", SkipMisclassification(string.Empty))
            },
            Readings = new List<Reading> { new(ReadingType("pinyin"), "ji2") },
            Meanings = new List<Meaning> { 
                new(Language("en"), "numerous"),
                new(Language("en"), "very many"),
                new(Language("en"), "large group of horses traveling in a line")
            }
        };
    }

    public static TestEntry 亀()
    {
        return new TestEntry
        {
            Literal = "亀",
            RadicalDecomposition = new List<string> { "亀", "田", "勹", "乙" },
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "4e80"),
                new(CodepointType("jis208"), "1-21-21")
            },
            StrokePaths = new List<string> {
                "M43.25,11.25c0.15,1.12,0.01,2.07-0.65,3C39,19.38,32.38,25.62,20.75,31.5",
                "M42.75,15.72c6.25-0.6,17.02-2.51,19.97-2.74c2.53-0.19,3.28,2.02,2.28,3.05c-4.88,4.97-7.13,8-11.83,13.47",
                "M29.32,32.43c0.89,0.93,1.24,2.33,1.46,3.53c0.96,5.17,1.81,9.31,2.58,14.55c0.21,1.41,0.41,2.82,0.6,4.2",
                "M31.8,33.95c11.26-1.8,33.02-4.53,42.95-5.27c3.42-0.26,6.17,0.76,5.4,4.7c-0.61,3.1-2.05,7.82-3.43,12.45c-0.46,1.54-0.93,3.1-1.41,4.63",
                "M33.11,42.87c11.26-1.74,34.76-3.87,44.65-4.3",
                "M34.79,52.41c11.96-1.66,29.05-3.13,40.02-3.8",
                "M24.83,62.09c0.79,0.79,1.05,1.91,1.28,3c1.09,5.1,1.73,11.04,2.41,17.4c0.18,1.65,0.35,3.25,0.52,4.76",
                "M26.67,64.33c13.08-2.08,35.71-4.83,50.54-6.03c2.86-0.23,5.07,1.44,4.56,4.34c-0.77,4.33-1.68,8.91-2.79,13.91c-0.39,1.76-1.02,3.46-1.32,5",
                "M28.6,74.1c14.19-2.11,39.03-4.72,50.67-5.41",
                "M29.9,83.97c15.85-2.47,37.68-4.54,47.51-5.19",
                "M51.74,33.62c0.88,0.88,1.12,2.34,1.12,4.18c0,8.33-0.03,39.33-0.03,45.7c0,10.5,2.17,12.53,20.42,12.53c17.25,0,19.25-1.28,19.39-11.87"
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(5), new IndexRadicalNelson(213) },
            IsIndexRadical = false,
            Grade = Grade(8),
            StrokeCount = 11,
            Variants = new List<Variant> { new(VariantType("jis208"), "1-83-93") },
            Frequency = 1353,
            JLPT = 1,
            References = new List<Reference> { 
                new(ReferenceType("nelson_c"), "5445"),
                new(ReferenceType("nelson_n"), "62"),
                new(ReferenceType("halpern_njecd"), "2128"),
                new(ReferenceType("halpern_kkd"), "2637"),
                new(ReferenceType("halpern_kkld"), "1346"),
                new(ReferenceType("halpern_kkld_2ed"), "1826"),
                new(ReferenceType("heisig"), "534"),
                new(ReferenceType("heisig6"), "573"),
                new(ReferenceType("gakken"), "1288"),
                new(ReferenceType("oneill_names"), "1531"),
                new(ReferenceType("oneill_kk"), "1921"),
                new(ReferenceType("moro"), "210 (vol 1, pg 0403)"),
                new(ReferenceType("sh_kk"), "2284"),
                new(ReferenceType("sh_kk2"), "1889"),
                new(ReferenceType("maniette"), "540")
            },
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "2-2-9", SkipMisclassification(string.Empty)),
                new(QueryCodeType("sh_desc"), "2n9.1"),
                new(QueryCodeType("four_corner"), "2771.6"),
                new(QueryCodeType("skip"), "4-11-4", SkipMisclassification("posn"))
            },
            Readings = new List<Reading> {
                new(ReadingType("pinyin"), "gui1"),
                new(ReadingType("pinyin"), "jun1"),
                new(ReadingType("pinyin"), "qiu1"),
                new(ReadingType("korean_r"), "gwi"),
                new(ReadingType("korean_r"), "gyun"),
                new(ReadingType("korean_h"), "귀"),
                new(ReadingType("korean_h"), "균"),
                new(ReadingType("vietnam"), "Quy"),
                new(ReadingType("vietnam"), "Qui"),
                new(ReadingType("ja_on"), "キ"),
                new(ReadingType("ja_on"), "キュウ"),
                new(ReadingType("ja_on"), "キン"),
                new(ReadingType("ja_kun"), "かめ")
            },
            Meanings = new List<Meaning> {
                new(Language("en"), "tortoise"),
                new(Language("en"), "turtle"),
                new(Language("fr"), "tortue"),
                new(Language("es"), "tortuga"),
            },
            Nanoris = new List<string> { "ひさ", "ひさし" }
        };
    }

    public static TestEntry 彁()
    {
        return new TestEntry
        {
            Literal = "彁",
            RadicalDecomposition = new List<string> { "弓", "口", "亅", "一" },
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "5f41"),
                new(CodepointType("jis208"), "1-55-27") 
            },
            StrokePaths = new List<string> {
                "M12.5,18.59c0.72,1.38,2.49,1.6,3.69,1.54C19,20,29.75,17.25,33.46,16.35c2.44-0.59,3.7,1.34,2.74,3.39c-0.95,2.04-3.31,11.03-3.96,14.01",
                "M16.75,35.75c1.75,0,14-2,15.25-2s2.5,0,3.5,0",
                "M16.13,34.68c0.55,0.96,0.46,4.56,0.11,6.08c-0.41,1.74-2.38,10.27-2.74,11.18c-1,2.56-0.25,4.56,2.75,3.06c1.21-0.6,11.75-3.25,15.96-3.69c2.99-0.31,2,5.21,1.79,6.94c-1.09,8.88-4.47,25.2-8.25,31.5C22,96,19.39,89.44,18.56,87.58",
                "M45,15.82c0.98,0.47,2.76,0.47,3.76,0.47c11.74-0.04,27.74-2.54,41.45-3.6c1.63-0.13,2.62,0.23,3.43,0.46",
                "M51.15,25.65c0.3,0.25,0.6,0.45,0.73,0.76c0.78,1.85,1.46,6,2.05,9.82c0.19,1.24,0.37,2.44,0.55,3.52",
                "M52.99,27.31c1.08-0.23,2.21-0.46,3.34-0.69c5.24-1.05,10.73-2.05,13.59-2.32c1.27-0.12,2.03,0.7,1.85,1.39c-0.58,2.19-1.23,4.73-2,7.57c-0.24,0.87-0.48,1.76-0.75,2.69",
                "M54.61,37.6c3.53-0.32,8.51-0.64,13.42-1.08c0.76-0.07,1.52-0.14,2.27-0.21",
                "M83.5,14.54c0.04,0.29,0.98,1.51,1.01,3.35c0.12,6.27,0.06,15.94-0.01,22.11c-0.03,2.53-0.07,4.47-0.09,5.35",
                "M43.13,51.25c0.97,0.31,4,0.88,5,0.81c12.12-0.81,25.87-2.31,44.22-3.55c1.62-0.11,2.59,0.15,3.4,0.31",
                "M50.93,61.48c0.31,0.33,0.62,0.6,0.76,1c0.87,2.64,1.65,8.88,2.29,14.23c0.14,1.18,0.28,2.33,0.41,3.38",
                "M52.35,63.67c0.64-0.09,1.29-0.18,1.95-0.27c6.25-0.86,13.36-1.82,16.62-2.21c1.32-0.15,2.11,0.92,1.92,1.83c-0.62,2.99-1.63,5.53-2.6,9.05c-0.25,0.92-0.51,1.92-0.75,3",
                "M55.05,77.76c3.57-0.4,8.54-0.82,13.49-1.38c0.92-0.1,1.85-0.21,2.76-0.33",
                "M84.41,51.32c0.06,0.29,0.79,1.51,0.85,3.35c0.27,8.83-0.17,32.16-0.17,35.17c0,10.41-5.34,1.91-6.85-0.81"
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(57) },
            StrokeCount = 13,
            References = new List<Reference> { new(ReferenceType("nelson_n"), "1701") },
            QueryCodes = new List<QueryCode> { 
                new(QueryCodeType("skip"), "1-3-10", SkipMisclassification(string.Empty)),
                new(QueryCodeType("sh_desc"), "3h10.1"),
                new(QueryCodeType("four_corner"), "1122.1")
            },
            Readings = new List<Reading> { 
                new(ReadingType("vietnam"), "Ca"),
                new(ReadingType("ja_on"), "カ"),
                new(ReadingType("ja_on"), "セイ")
            },
            Meanings = new List<Meaning> { new(Language("en"), "(phantom kanji)") }
        };
    }

    public static TestEntry 鰹()
    {
        return new TestEntry
        {
            Literal = "鰹",
            RadicalDecomposition = new List<string> { "魚", "臣", "田", "土", "又", "⺣" },
            StrokePaths = new List<string> {
                "M23.5,13.5c0.12,1.44-0.32,2.84-0.82,4.19C20,23.5,16.62,30,10.24,36.87",
                "M23.14,20.88c1.61,0,8.42-0.75,11.99-1.25c2.97-0.42,4.11,1.28,2.55,3.98c-2.84,4.91-4.77,9.54-9.48,17.35",
                "M11.47,42.43c0.68,0.67,1.02,1.83,1.08,2.46c0.68,6.94,1.38,13.3,2.06,21.25c0.15,1.77,0.3,3.62,0.45,5.58",
                "M13.44,44.25c7.8-1.36,18.25-3.23,24.19-4.02c2.23-0.3,4.67,0.83,4.44,3.52c-0.43,4.86-1.64,13.62-2.75,20.52c-0.33,2.04-0.65,3.92-0.93,5.49",
                "M26.29,44.08c0.88,0.88,0.97,2.04,0.97,3.67c0,4.76,0.02,16.32,0.02,19.87",
                "M15,56.33c7.13-1.08,20.75-2.33,25.05-2.79",
                "M16.43,70.07c6.69-0.7,13.45-1.74,21.19-2.32",
                "M12.58,81.82c0,5.32-2.07,13.16-2.6,14.68",
                "M19.85,80.33c1.79,2.55,3.49,9.57,3.94,13.54",
                "M29.21,77.94c1.46,2.15,3.78,8.86,4.15,12.21",
                "M37.3,75.87c2.19,2.17,5.65,8.91,6.2,12.28",
                "M51.41,19.17c0.96,0.96,1.08,1.95,1.08,3.12c0,2.82-0.07,20.17-0.1,31.09c-0.01,3.44-0.02,6.25-0.02,7.75",
                "M53.06,19.91c3.94-0.6,10.07-1.57,14.84-2.14c0.94-0.15,1.89-0.21,2.84-0.19",
                "M62.06,20.86c0.46,0.79,0.66,1.63,0.61,2.51c0.04,1.71,0.05,4.5,0.02,7.05",
                "M53.78,33.25c5.21-0.98,10.35-1.96,13.86-2.71c1.71-0.36,3.3,0.25,2.93,2.47c-0.43,2.54-1.03,5.33-1.81,8.49",
                "M53.63,44.32c2.71-0.32,8.59-1.07,13.12-1.53c1.72-0.17,3.21-0.31,4.19-0.36",
                "M61.46,45.65c0.5,0.9,0.7,1.85,0.62,2.85c0.04,2.3,0.06,6.52,0.03,9.02",
                "M53.35,59.48c5.05-0.52,9.67-0.91,13.91-1.35c1.2-0.19,2.41-0.28,3.63-0.26",
                "M75.19,20.47c0.75,0.28,2.59,0.45,4.1,0.03c1.25-0.35,9-2.11,12.2-2.8c1.77-0.38,3.93,0.28,3.2,2.82C90,36.88,84,48.12,75.62,56.25",
                "M75.53,25.89C77.38,26.52,84,39.12,90.91,50.1c1.77,2.81,3.99,5.17,6.73,7.01",
                "M54.36,75.06c1.87,0.31,3.75,0.38,5.64,0.21c7.7-0.78,18.01-1.91,25.63-2.24c1.64-0.18,3.28-0.12,4.9,0.18",
                "M70.98,61.74c0.76,0.76,0.99,2.51,0.99,3.72c0,5.79-0.2,21.67-0.2,27.09",
                "M49.54,93.32c2.79,0.71,5.56,0.44,8.45,0.23C69.21,92.75,80.5,91.88,91,91.76c2.45-0.03,4.86,0.38,7.23,0.93"
            },
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "9c39"),
                new(CodepointType("jis208"), "1-19-79") 
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(195) },
            StrokeCount = 23,
            StrokeCommonMiscounts = new List<int> { 22 },
            References = new List<Reference> {
                new(ReferenceType("nelson_c"), "5327"),
                new(ReferenceType("nelson_n"), "6915"),
                new(ReferenceType("heisig"), "2822"),
                new(ReferenceType("heisig6"), "2837"),
                new(ReferenceType("moro"), "46437 (vol 12, pg 0766)")
            },
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "1-11-12", SkipMisclassification(string.Empty)),
                new(QueryCodeType("sh_desc"), "11a12.1"),
                new(QueryCodeType("four_corner"), "2731.4"),
            },
            Readings = new List<Reading> {
                new(ReadingType("pinyin"), "jian1"),
                new(ReadingType("korean_r"), "gyeon"),
                new(ReadingType("korean_h"), "견"),
                new(ReadingType("vietnam"), "Kiên"),
                new(ReadingType("ja_on"), "ケン"),
                new(ReadingType("ja_kun"), "かつお")
            },
            Meanings = new List<Meaning> { new(Language("en"), "bonito") }
        };
    }

    public static TestEntry 夊()
    {
        return new TestEntry
        {
            Literal = "夊",
            RadicalDecomposition = new List<string> { "夂" },
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "590a"),
                new(CodepointType("jis208"), "1-52-74") 
            },
            StrokePaths = new List<string> {
                "M52.54,13.75c0.09,1.14,0.19,2.93-0.18,4.57c-2.2,9.63-14.33,31.25-31.61,44.18",
                "M48.14,35.78c0.46,0.05,2.9,0.45,4.19,0.32c5.79-0.58,16.07-2.7,22.14-4.16c4.17-1,5.35,1.14,4.29,3.86C72.92,50.68,43.51,87.09,17.5,94.75",
                "M24.25,30.5c2.25,0,4.41,1.74,4.99,2.73C42,55,66.5,79.75,83.33,89.86c3.99,2.4,6.61,4.28,10.17,5.14"
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(35), new IndexRadicalNelson(34) },
            IsIndexRadical = true,
            StrokeCount = 3,
            RadicalNames = new List<string> { "すいにょう" },
            References = new List<Reference> { 
                new(ReferenceType("nelson_n"), "1122"),
                new(ReferenceType("halpern_njecd"), "3393"),
                new(ReferenceType("halpern_kkd"), "4201"),
                new(ReferenceType("moro"), "5708 (vol 3, pg 0302)")
            },
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "4-3-1", SkipMisclassification(string.Empty)),
                new(QueryCodeType("sh_desc"), "0a3.30"),
                new(QueryCodeType("four_corner"), "4740.0"),
                new(QueryCodeType("four_corner"), "2740.0"),
                new(QueryCodeType("skip"), "4-3-4", SkipMisclassification("posn")),
            },
            Readings = new List<Reading> {
                new(ReadingType("pinyin"), "sui1"),
                new(ReadingType("korean_r"), "soe"),
                new(ReadingType("korean_h"), "쇠"),
                new(ReadingType("vietnam"), "Tuy"),
                new(ReadingType("ja_on"), "スイ"),
                new(ReadingType("ja_kun"), "ゆき")
            },
            Meanings = new List<Meaning> { new(Language("en"), "winter variant radical (no. 34)") }
        };
    }

    public static TestEntry 亜()
    {
        return new TestEntry
        {
            Literal = "亜",
            RadicalDecomposition = new List<string> { "｜", "一", "口" },
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "4e9c"),
                new(CodepointType("jis208"), "1-16-01")
            },
            StrokePaths = new List<string> {
                "M23.38,21.68c2.99,0.65,5.98,0.58,9.01,0.33c13.11-1.04,30.12-2.73,45.99-3.15c2.81-0.07,5.73-0.07,8.5,0.53",
                "M20,43.14c1.19,0.96,1.48,1.7,1.82,3.1c1.31,5.39,2.44,12.96,3.43,19.51c0.3,2,0.57,3.56,0.81,5",
                "M22.75,45.54c23-2.79,41.54-4.46,60.89-5.84c3.48-0.25,6.74,0.45,5.39,5.54c-1.26,4.77-3.41,11.01-5.27,16.76",
                "M26.5,67c19.64-1.66,31.34-2.67,50.25-3.8c2.63-0.25,5.26-0.28,7.89-0.09",
                "M42.12,24c1.09,1.56,1.57,3.23,1.46,5.01c0,7.22,0.03,50.43,0.03,58.99",
                "M62.62,22.75c0.91,1.63,1.32,3.09,1.21,4.88c0,8.29,0.03,52.17,0.03,58.88",
                "M15.88,89.23c3.62,0.65,7.25,0.71,10.62,0.49c18.61-1.21,42.5-2.34,60.12-2.56c3.21-0.04,6.34,0.23,9.5,0.91"
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(7), new IndexRadicalNelson(1) },
            Grade = Grade(8),
            StrokeCount = 7,
            Variants = new List<Variant> { new(VariantType("jis208"), "1-48-19") },
            Frequency = 1509,
            JLPT = 1,
            References = new List<Reference> {
                new(ReferenceType("nelson_c"), "43"),
                new(ReferenceType("nelson_n"), "81"),
                new(ReferenceType("halpern_njecd"), "3540"),
                new(ReferenceType("halpern_kkd"), "4354"),
                new(ReferenceType("halpern_kkld"), "2204"),
                new(ReferenceType("halpern_kkld_2ed"), "2966"),
                new(ReferenceType("heisig"), "1809"),
                new(ReferenceType("heisig6"), "1950"),
                new(ReferenceType("gakken"), "1331"),
                new(ReferenceType("oneill_names"), "525"),
                new(ReferenceType("oneill_kk"), "1788"),
                new(ReferenceType("moro"), "272 (vol 1, pg 0525)"),
                new(ReferenceType("henshall"), "997"),
                new(ReferenceType("sh_kk"), "1616"),
                new(ReferenceType("sh_kk2"), "1724"),
                new(ReferenceType("jf_cards"), "1032"),
                new(ReferenceType("tutt_cards"), "1092"),
                new(ReferenceType("kanji_in_context"), "1818"),
                new(ReferenceType("kodansha_compact"), "35"),
                new(ReferenceType("maniette"), "1827")
            },
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "4-7-1", SkipMisclassification(string.Empty)),
                new(QueryCodeType("sh_desc"), "0a7.14"),
                new(QueryCodeType("four_corner"), "1010.6"),
                new(QueryCodeType("deroo"), "3273")
            },
            Readings = new List<Reading> {
                new(ReadingType("pinyin"), "ya4"),
                new(ReadingType("korean_r"), "a"),
                new(ReadingType("korean_h"), "아"),
                new(ReadingType("vietnam"), "A"),
                new(ReadingType("vietnam"), "Á"),
                new(ReadingType("ja_on"), "ア"),
                new(ReadingType("ja_kun"), "つ.ぐ")
            },
            Meanings = new List<Meaning> {
                new(Language("en"), "Asia"),
                new(Language("en"), "rank next"),
                new(Language("en"), "come after"),
                new(Language("en"), "-ous"),
                new(Language("fr"), "Asie"),
                new(Language("fr"), "suivant"),
                new(Language("fr"), "sub-"),
                new(Language("fr"), "sous-"),
                new(Language("es"), "pref. para indicar"),
                new(Language("es"), "venir después de"),
                new(Language("es"), "Asia"),
                new(Language("pt"), "Ásia"),
                new(Language("pt"), "próxima"),
                new(Language("pt"), "o que vem depois"),
                new(Language("pt"), "-ous")
            },
            Nanoris = new List<string> { "や", "つぎ", "つぐ" }
        };
    }

    public static TestEntry 頻()
    {
        return new TestEntry
        {
            Literal = "頻",
            Codepoints = new List<Codepoint> {
                new(CodepointType("ucs"), "FA6A"),
                new(CodepointType("jis213"), "1-93-91")
            },
            IndexRadicals = new List<IIndexRadical> { IndexRadicalKangxi(181) },
            StrokeCount = 16,
            Variants = new List<Variant> { new(VariantType("jis208"), "1-41-49") },
            References = new List<Reference> {
                new(ReferenceType("nelson_n"), "6631"),
                new(ReferenceType("halpern_njecd"), "1613"),
                new(ReferenceType("halpern_kkd"), "2038"),
                new(ReferenceType("moro"), "43519")
            },
            QueryCodes = new List<QueryCode> {
                new(QueryCodeType("skip"), "1-7-9", SkipMisclassification(string.Empty))
            },
            Readings = new List<Reading> {
                new(ReadingType("ja_on"), "ヒン"),
            }
        };
    }

    public static TestEntry FullObject()
    {
        return new TestEntry
        {
            Literal = "[Literal]",
            RadicalDecomposition = new []{ "[RadicalDecomposition]" },
            Codepoints = new []{ new Codepoint(Enums.CodepointType.Unicode, "[Codepoint]") },
            StrokePaths = new []{ "[StrokePath]" },
            IndexRadicals = new IIndexRadical[]{ Enums.IndexRadicalKangxi.Radical214, new IndexRadicalNelson(1) },
            IsIndexRadical = true,
            Grade = Enums.Grade.JinmeiyouTraditional,
            StrokeCount = 99,
            StrokeCommonMiscounts = new []{ 100 },
            Variants = new []{ new Variant(Enums.VariantType.Unicode, "[Variant]") },
            Frequency = 99,
            RadicalNames = new [] { "[RadicalName]" },
            JLPT = 99,
            References = new []{ new Reference(Enums.ReferenceType.Maniette, "[Reference]") },
            QueryCodes = new []{ new QueryCode(Enums.QueryCodeType.DeRoo, "[QueryCode]") },
            Readings = new []{ new Reading(Enums.ReadingType.JapaneseKun, "[Reading]") },
            Meanings = new []{ new Meaning(Enums.Language.Yiddish, "[Meaning]") },
            Nanoris = new []{ "[Nanori]"}
        };
    }

    private static CodepointType CodepointType(string code) => Enumeration.GetAll<CodepointType>().Single(x => x.Code == code);
    private static IndexRadicalKangxi IndexRadicalKangxi(int code) => Enumeration.GetAll<IndexRadicalKangxi>().Single(x => x.Number == code);
    private static Grade Grade(int code) => Enumeration.GetAll<Grade>().Single(x => x.Number == code);
    private static Language Language(string code) => Enumeration.GetAll<Language>().Single(x => x.TwoLetterCode == code);
    private static QueryCodeType QueryCodeType(string code) => Enumeration.GetAll<QueryCodeType>().Single(x => x.Code == code);
    private static ReadingType ReadingType(string code) => Enumeration.GetAll<ReadingType>().Single(x => x.Code == code);
    private static ReferenceType ReferenceType(string code) => Enumeration.GetAll<ReferenceType>().Single(x => x.Code == code);
    private static SkipMisclassification SkipMisclassification(string code) => Enumeration.GetAll<SkipMisclassification>().Single(x => x.Code == code);
    private static VariantType VariantType(string code) => Enumeration.GetAll<VariantType>().Single(x => x.Code == code);
}