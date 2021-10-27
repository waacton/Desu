namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Radicals;
    using Wacton.Desu.Strokes;

    internal class CharacterElement : Enumeration
    {
        public static readonly CharacterElement Literal = new CharacterElement("Literal", "literal", AddLiteral);

        public static readonly CharacterElement CodepointValue = new CharacterElement("CodepointValue", "cp_value", AddCodepoint);

        public static readonly CharacterElement RadicalValue = new CharacterElement("RadicalValue", "rad_value", AddRadical);

        public static readonly CharacterElement Grade = new CharacterElement("Grade", "grade", AddGrade);
        public static readonly CharacterElement StrokeCount = new CharacterElement("StrokeCount", "stroke_count", AddStrokeCount);
        public static readonly CharacterElement Variant = new CharacterElement("Variant", "variant", AddVariant);
        public static readonly CharacterElement Frequency = new CharacterElement("Frequency", "freq", AddFrequency);
        public static readonly CharacterElement RadicalName = new CharacterElement("RadicalName", "rad_name", AddRadicalName);
        public static readonly CharacterElement JLPT = new CharacterElement("JLPT", "jlpt", AddJLPT);

        public static readonly CharacterElement Reference = new CharacterElement("Reference", "dic_ref", AddReference);

        public static readonly CharacterElement QueryCode = new CharacterElement("QueryCode", "q_code", AddQueryCode);

        public static readonly CharacterElement Reading = new CharacterElement("Reading", "reading", AddReading);
        public static readonly CharacterElement Meaning = new CharacterElement("Meaning", "meaning", AddMeaning);
        public static readonly CharacterElement Nanori = new CharacterElement("Nanori", "nanori", AddNanori);

        private static readonly Dictionary<string, Language> Languages = GetAll<Language>().Where(language => language.TwoLetterCode != null).ToDictionary(language => language.TwoLetterCode, language => language);

        private static readonly Dictionary<string, CodepointType> CodepointTypes = GetAll<CodepointType>().ToDictionary(codepointType => codepointType.Code, codepointType => codepointType);
        private static readonly Dictionary<string, BushuRadicalType> RadicalTypes = GetAll<BushuRadicalType>().ToDictionary(radicalType => radicalType.Code, radicalType => radicalType);
        private static readonly Dictionary<int, BushuRadicalClassical> ClassicalBushuRadicals = GetAll<BushuRadicalClassical>().ToDictionary(classicalBushuRadical => classicalBushuRadical.Number, classicalBushuRadical => classicalBushuRadical);
        private static readonly Dictionary<int, Grade> Grades = GetAll<Grade>().ToDictionary(grade => grade.Number, grade => grade);
        private static readonly Dictionary<string, VariantType> VariantTypes = GetAll<VariantType>().ToDictionary(variantType => variantType.Code, variantType => variantType);
        private static readonly Dictionary<string, ReferenceType> ReferenceTypes = GetAll<ReferenceType>().ToDictionary(referenceType => referenceType.Code, referenceType => referenceType);
        private static readonly Dictionary<string, QueryCodeType> QueryCodeTypes = GetAll<QueryCodeType>().ToDictionary(queryCodeType => queryCodeType.Code, queryCodeType => queryCodeType);
        private static readonly Dictionary<string, SkipMisclassification> SkipMisclassifications = GetAll<SkipMisclassification>().ToDictionary(skipMisclassification => skipMisclassification.Code, skipMisclassification => skipMisclassification);
        private static readonly Dictionary<string, ReadingType> ReadingTypes = GetAll<ReadingType>().ToDictionary(readingType => readingType.Code, readingType => readingType);

        private static readonly IDictionary<string, IEnumerable<string>> RadicalLookup = Radicals.RadicalLookup.ParseKanjiToRadicals();
        private static readonly IDictionary<string, IEnumerable<string>> StrokeLookup = Strokes.StrokeLookup.ParseKanjiToStrokes();

        public string Code { get; }

        private readonly Action<KanjiEntry, CharacterElementData> addDataToEntryAction;

        public CharacterElement(string displayName, string code, Action<KanjiEntry, CharacterElementData> addDataToEntryAction = null)
            : base(displayName)
        {
            Code = code;
            this.addDataToEntryAction = addDataToEntryAction ?? ((entry, data) => { });
        }

        internal void AddDataToEntry(KanjiEntry entry, CharacterElementData data)
        {
            addDataToEntryAction(entry, data);
        }

        private static void AddLiteral(KanjiEntry entry, CharacterElementData data)
        {
            entry.Literal = data.Content;

            var radicalDecomposition = RadicalLookup.ContainsKey(entry.Literal)
                ? RadicalLookup[entry.Literal]
                : new List<string>();

            var radicals = entry.RadicalDecompositionList;
            radicals.AddRange(radicalDecomposition);
        }

        private static void AddCodepoint(KanjiEntry entry, CharacterElementData data)
        {
            var codepoint = new Codepoint(CodepointTypes[data.CodepointTypeAttribute], data.Content);
            entry.CodepointsList.Add(codepoint);

            if (!codepoint.Type.Equals(CodepointType.Unicode))
            {
                return;
            }

            var fiveLetterUnicode = codepoint.Value.PadLeft(5, '0');
            if (!StrokeLookup.ContainsKey(fiveLetterUnicode))
            {
                return;
            }

            var entryStrokePaths = entry.StrokePathsList;
            entryStrokePaths.AddRange(StrokeLookup[fiveLetterUnicode]);
        }

        private static void AddRadical(KanjiEntry entry, CharacterElementData data)
        {
            IBushuRadical bushuRadical;

            var radicalType = RadicalTypes[data.RadicalTypeAttribute];
            var radicalNumber = int.Parse(data.Content);

            if (radicalType.Equals(BushuRadicalType.Classical))
            {
                bushuRadical = ClassicalBushuRadicals.ContainsKey(radicalNumber) ? ClassicalBushuRadicals[radicalNumber] : null;
            }
            else
            {
                bushuRadical = new BushuRadicalNelson(radicalNumber);
            }

            entry.BushuRadicalsList.Add(bushuRadical);
        }

        private static void AddGrade(KanjiEntry entry, CharacterElementData data)
        {
            entry.Grade = Grades[int.Parse(data.Content)];
        }

        private static void AddStrokeCount(KanjiEntry entry, CharacterElementData data)
        {
            var strokeCount = int.Parse(data.Content);

            if (entry.StrokeCount == 0)
            {
                entry.StrokeCount = strokeCount;
            }
            else
            {
                entry.StrokeCommonMiscountsList.Add(strokeCount);
            }
        }

        private static void AddVariant(KanjiEntry entry, CharacterElementData data)
        {
            entry.VariantsList.Add(new Variant(VariantTypes[data.VariantTypeAttribute], data.Content));
        }

        private static void AddFrequency(KanjiEntry entry, CharacterElementData data)
        {
            entry.Frequency = int.Parse(data.Content);
        }

        private static void AddRadicalName(KanjiEntry entry, CharacterElementData data)
        {
            entry.RadicalNamesList.Add(data.Content);
        }

        private static void AddJLPT(KanjiEntry entry, CharacterElementData data)
        {
            entry.JLPT = int.Parse(data.Content);
        }

        private static void AddReference(KanjiEntry entry, CharacterElementData data)
        {
            var content = data.Content;
            var additionalContents = new List<string>();
            if (!string.IsNullOrEmpty(data.ReferenceVolumeAttribute))
            {
                additionalContents.Add($"vol {data.ReferenceVolumeAttribute}");
            }

            if (!string.IsNullOrEmpty(data.ReferencePageAttribute))
            {
                additionalContents.Add($"pg {data.ReferencePageAttribute}");
            }

            if (additionalContents.Any())
            {
                content = $"{content} ({string.Join(", ", additionalContents)})";
            }

            entry.ReferencesList.Add(new Reference(ReferenceTypes[data.ReferenceTypeAttribute], content));
        }

        private static void AddQueryCode(KanjiEntry entry, CharacterElementData data)
        {
            SkipMisclassification skipMisclassification = null;
            var queryCodeType = QueryCodeTypes[data.QueryCodeTypeAttribute];
            if (queryCodeType.Equals(QueryCodeType.SKIP))
            {
                skipMisclassification = !string.IsNullOrEmpty(data.SkipMisclassificationAttribute)
                    ? SkipMisclassifications[data.SkipMisclassificationAttribute]
                    : SkipMisclassification.None;
            }

            entry.QueryCodesList.Add(new QueryCode(QueryCodeTypes[data.QueryCodeTypeAttribute], data.Content, skipMisclassification));
        }

        private static void AddReading(KanjiEntry entry, CharacterElementData data)
        {
            entry.ReadingsList.Add(new Reading(ReadingTypes[data.ReadingTypeAttribute], data.Content));
        }

        private static void AddMeaning(KanjiEntry entry, CharacterElementData data)
        {
            var language = string.IsNullOrEmpty(data.LanguageAttribute)
                ? Language.English
                : Languages[data.LanguageAttribute];

            entry.MeaningsList.Add(new Meaning(language, data.Content));
        }

        private static void AddNanori(KanjiEntry entry, CharacterElementData data)
        {
            entry.NanorisList.Add(data.Content);
        }
    }
}
