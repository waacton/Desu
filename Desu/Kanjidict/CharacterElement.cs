namespace Wacton.Desu.Kanjidict
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Tovarisch.Enum;

    public class CharacterElement : Enumeration
    {
        public static readonly CharacterElement Literal = new CharacterElement("Literal", "literal", (entry, data) => entry.Literal = data.Content);

        //public static readonly CharacterElement Codepoint = new CharacterElement("Codepoint", "codepoint", (entry, data) => entry.StartNewCodepoint(), false);
        public static readonly CharacterElement CodepointValue = new CharacterElement("CodepointValue", "cp_value", AddCodepoint);

        //public static readonly CharacterElement KanjiText = new CharacterElement("KanjiText", "keb", (entry, data) => entry.GetKanji().Text = data.Content);
        //public static readonly CharacterElement KanjiInformation = new CharacterElement("KanjiInformation", "ke_inf", (entry, data) => AddContent(entry.GetKanji().GetInformations(), data, KanjiInformations));
        //public static readonly CharacterElement KanjiPriority = new CharacterElement("KanjiPriority", "ke_pri", (entry, data) => AddContent(entry.GetKanji().GetPriorities(), data, Priorities));

        //public static readonly CharacterElement Reading = new CharacterElement("Reading", "r_ele", (entry, data) => entry.StartNewReading(), false);
        //public static readonly CharacterElement ReadingText = new CharacterElement("ReadingText", "reb", (entry, data) => entry.GetReading().Text = data.Content);
        //public static readonly CharacterElement ReadingNoKanji = new CharacterElement("ReadingNoKanji", "re_nokanji", (entry, data) => entry.GetReading().IsTrueKanjiReading = false);
        //public static readonly CharacterElement ReadingRestriction = new CharacterElement("ReadingRestriction", "re_restr", (entry, data) => AddContent(entry.GetReading().GetRestriction(), data));
        //public static readonly CharacterElement ReadingInformation = new CharacterElement("ReadingInformation", "re_inf", (entry, data) => AddContent(entry.GetReading().GetInformations(), data, ReadingInformations));
        //public static readonly CharacterElement ReadingPriority = new CharacterElement("ReadingPriority", "re_pri", (entry, data) => AddContent(entry.GetReading().GetPriorities(), data, Priorities));

        //public static readonly CharacterElement Sense = new CharacterElement("Sense", "sense", (entry, data) => entry.StartNewSense(), false);
        //public static readonly CharacterElement SenseKanjiRestriction = new CharacterElement("SenseKanjiRestriction", "stagk", (entry, data) => AddContent(entry.GetSense().GetKanjiRestriction(), data));
        //public static readonly CharacterElement SenseReadingRestriction = new CharacterElement("SenseReadingRestriction", "stagr", (entry, data) => AddContent(entry.GetSense().GetReadingRestriction(), data));
        //public static readonly CharacterElement PartOfSpeech = new CharacterElement("PartOfSpeech", "pos", (entry, data) => AddContent(entry.GetSense().GetPartsOfSpeech(), data, PartsOfSpeech));
        //public static readonly CharacterElement CrossReference = new CharacterElement("CrossReference", "xref", (entry, data) => AddContent(entry.GetSense().GetCrossReferences(), data));
        //public static readonly CharacterElement Antonym = new CharacterElement("Antonym", "ant", (entry, data) => AddContent(entry.GetSense().GetAntonyms(), data));
        //public static readonly CharacterElement Field = new CharacterElement("Field", "field", (entry, data) => AddContent(entry.GetSense().GetFields(), data, Fields));
        //public static readonly CharacterElement Miscellaneous = new CharacterElement("Miscellaneous", "misc", (entry, data) => AddContent(entry.GetSense().GetMiscellanea(), data, Miscellanea));
        //public static readonly CharacterElement SenseInformation = new CharacterElement("SenseInformation", "s_inf", (entry, data) => AddContent(entry.GetSense().GetInformations(), data));
        //public static readonly CharacterElement LoanwordSource = new CharacterElement("LoanwordSource", "lsource", (entry, data) => AddLoanwordGloss(entry.GetSense().GetLoanwordSources(), data));
        //public static readonly CharacterElement Dialect = new CharacterElement("Dialect", "dial", (entry, data) => AddContent(entry.GetSense().GetDialects(), data, Dialects));
        //public static readonly CharacterElement Gloss = new CharacterElement("Gloss", "gloss", (entry, data) => AddGloss(entry.GetSense().GetGlosses(), data));

        //private static readonly Dictionary<string, Language> Languages = GetAll<Language>().ToDictionary(language => language.Code, language => language);

        private static readonly Dictionary<string, CodepointType> CodepointTypes = GetAll<CodepointType>().ToDictionary(codepointType => codepointType.Code, codepointType => codepointType);
        //private static readonly Dictionary<string, Field> Fields = GetAll<Field>().ToDictionary(field => field.Code, field => field);
        //private static readonly Dictionary<string, KanjiInformation> KanjiInformations = GetAll<KanjiInformation>().ToDictionary(information => information.Code, information => information);
        //private static readonly Dictionary<string, Miscellaneous> Miscellanea = GetAll<Miscellaneous>().ToDictionary(miscellaneous => miscellaneous.Code, miscellaneous => miscellaneous);
        //private static readonly Dictionary<string, PartOfSpeech> PartsOfSpeech = GetAll<PartOfSpeech>().ToDictionary(partOfSpeech => partOfSpeech.Code, partOfSpeech => partOfSpeech);
        //private static readonly Dictionary<string, Priority> Priorities = GetAll<Priority>().ToDictionary(priority => priority.Code, priority => priority);
        //private static readonly Dictionary<string, ReadingInformation> ReadingInformations = GetAll<ReadingInformation>().ToDictionary(information => information.Code, information => information);

        public string Code { get; }
        public bool ExpectsContent { get; }
        private readonly Action<KanjiDictionaryEntry, CharacterElementData> addDataToEntryAction;

        public CharacterElement(string displayName, string code, Action<KanjiDictionaryEntry, CharacterElementData> addDataToEntryAction = null, bool expectsContent = true)
            : base(displayName)
        {
            this.Code = code;
            this.addDataToEntryAction = addDataToEntryAction ?? ((entry, data) => { });
            this.ExpectsContent = expectsContent;
        }

        internal void AddDataToEntry(KanjiDictionaryEntry entry, CharacterElementData data)
        {
            this.addDataToEntryAction(entry, data);
        }

        private static void AddContent(List<string> list, CharacterElementData data)
        {
            list.Add(data.Content);
        }

        private static void AddContent<T>(List<T> list, CharacterElementData data, Dictionary<string, T> lookupDictionary)
        {
            list.Add(lookupDictionary[data.Content]);
        }

        private static void AddCodepoint(KanjiDictionaryEntry entry, CharacterElementData data)
        {
            entry.AddCodepoint(new Codepoint(CodepointTypes[data.CodepointTypeAttribute], data.Content));
        }

        //private static void AddGloss(List<Gloss> list, CharacterElementData data)
        //{
        //    list.Add(new Gloss(data.Content, Languages[data.LanguageAttribute], data.GlossGenderAttribute));
        //}

        //private static void AddLoanwordGloss(List<LoanwordGloss> list, CharacterElementData data)
        //{
        //    list.Add(new LoanwordGloss(data.Content, Languages[data.LanguageAttribute], data.GlossGenderAttribute, data.LoanwordTypeAttribute != null, data.LoanwordWaseiAttribute != null));
        //}
    }
}
