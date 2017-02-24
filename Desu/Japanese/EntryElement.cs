namespace Wacton.Desu.Japanese
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;
    using Wacton.Tovarisch.Enum;

    public class EntryElement : Enumeration
    {
        public static readonly EntryElement Sequence = new EntryElement("Sequence", "ent_seq", (entry, data) => entry.Sequence = int.Parse(data.Content));

        public static readonly EntryElement Kanji = new EntryElement("Kanji", "k_ele", (entry, data) => entry.StartNewKanji(), false);
        public static readonly EntryElement KanjiText = new EntryElement("KanjiText", "keb", (entry, data) => entry.GetKanjis().Last().Text = data.Content);
        public static readonly EntryElement KanjiInformation = new EntryElement("KanjiInformation", "ke_inf", (entry, data) => AddContent(entry.GetKanjis().Last().GetInformations(), data, KanjiInformations));
        public static readonly EntryElement KanjiPriority = new EntryElement("KanjiPriority", "ke_pri", (entry, data) => AddContent(entry.GetKanjis().Last().GetPriorities(), data, Priorities));

        public static readonly EntryElement Reading = new EntryElement("Reading", "r_ele", (entry, data) => entry.StartNewReading(), false);
        public static readonly EntryElement ReadingText = new EntryElement("ReadingText", "reb", (entry, data) => entry.GetReadings().Last().Text = data.Content);
        public static readonly EntryElement ReadingNoKanji = new EntryElement("ReadingNoKanji", "re_nokanji", (entry, data) => entry.GetReadings().Last().IsTrueKanjiReading = false);
        public static readonly EntryElement ReadingRestriction = new EntryElement("ReadingRestriction", "re_restr", (entry, data) => AddContent(entry.GetReadings().Last().GetRestriction(), data));
        public static readonly EntryElement ReadingInformation = new EntryElement("ReadingInformation", "re_inf", (entry, data) => AddContent(entry.GetReadings().Last().GetInformations(), data, ReadingInformations));
        public static readonly EntryElement ReadingPriority = new EntryElement("ReadingPriority", "re_pri", (entry, data) => AddContent(entry.GetReadings().Last().GetPriorities(), data, Priorities));

        public static readonly EntryElement Sense = new EntryElement("Sense", "sense", (entry, data) => entry.StartNewSense(), false);
        public static readonly EntryElement SenseKanjiRestriction = new EntryElement("SenseKanjiRestriction", "stagk", (entry, data) => AddContent(entry.GetSenses().Last().GetKanjiRestriction(), data));
        public static readonly EntryElement SenseReadingRestriction = new EntryElement("SenseReadingRestriction", "stagr", (entry, data) => AddContent(entry.GetSenses().Last().GetReadingRestriction(), data));
        public static readonly EntryElement PartOfSpeech = new EntryElement("PartOfSpeech", "pos", (entry, data) => AddContent(entry.GetSenses().Last().GetPartsOfSpeech(), data, PartsOfSpeech));
        public static readonly EntryElement CrossReference = new EntryElement("CrossReference", "xref", (entry, data) => AddContent(entry.GetSenses().Last().GetCrossReferences(), data));
        public static readonly EntryElement Antonym = new EntryElement("Antonym", "ant", (entry, data) => AddContent(entry.GetSenses().Last().GetAntonyms(), data));
        public static readonly EntryElement Field = new EntryElement("Field", "field", (entry, data) => AddContent(entry.GetSenses().Last().GetFields(), data, Fields));
        public static readonly EntryElement Miscellaneous = new EntryElement("Miscellaneous", "misc", (entry, data) => AddContent(entry.GetSenses().Last().GetMiscellanea(), data, Miscellanea));
        public static readonly EntryElement SenseInformation = new EntryElement("SenseInformation", "s_inf", (entry, data) => AddContent(entry.GetSenses().Last().GetInformations(), data));
        public static readonly EntryElement LoanwordSource = new EntryElement("LoanwordSource", "lsource", (entry, data) => AddLoanwordGloss(entry.GetSenses().Last().GetLoanwordSources(), data));
        public static readonly EntryElement Dialect = new EntryElement("Dialect", "dial", (entry, data) => AddContent(entry.GetSenses().Last().GetDialects(), data, Dialects));
        public static readonly EntryElement Gloss = new EntryElement("Gloss", "gloss", (entry, data) => AddGloss(entry.GetSenses().Last().GetGlosses(), data));

        private static readonly Dictionary<string, Language> Languages = GetAll<Language>().ToDictionary(language => language.ThreeLetterCode, language => language);

        private static readonly Dictionary<string, Dialect> Dialects = GetAll<Dialect>().ToDictionary(dialect => dialect.Code, dialect => dialect);
        private static readonly Dictionary<string, Field> Fields = GetAll<Field>().ToDictionary(field => field.Code, field => field);
        private static readonly Dictionary<string, KanjiInformation> KanjiInformations = GetAll<KanjiInformation>().ToDictionary(information => information.Code, information => information);
        private static readonly Dictionary<string, Miscellaneous> Miscellanea = GetAll<Miscellaneous>().ToDictionary(miscellaneous => miscellaneous.Code, miscellaneous => miscellaneous);
        private static readonly Dictionary<string, PartOfSpeech> PartsOfSpeech = GetAll<PartOfSpeech>().ToDictionary(partOfSpeech => partOfSpeech.Code, partOfSpeech => partOfSpeech);
        private static readonly Dictionary<string, Priority> Priorities = GetAll<Priority>().ToDictionary(priority => priority.Code, priority => priority);
        private static readonly Dictionary<string, ReadingInformation> ReadingInformations = GetAll<ReadingInformation>().ToDictionary(information => information.Code, information => information);

        public string Code { get; }
        public bool ExpectsContent { get; }

        private readonly Action<JapaneseEntry, EntryElementData> addDataToEntryAction;

        public EntryElement(string displayName, string code, Action<JapaneseEntry, EntryElementData> addDataToEntryAction = null, bool expectsContent = true)
            : base(displayName)
        {
            this.Code = code;
            this.addDataToEntryAction = addDataToEntryAction ?? ((entry, data) => { });
            this.ExpectsContent = expectsContent;
        }

        internal void AddDataToEntry(JapaneseEntry entry, EntryElementData data)
        {
            this.addDataToEntryAction(entry, data);
        }

        private static void AddContent(List<string> list, EntryElementData data)
        {
            list.Add(data.Content);
        }

        private static void AddContent<T>(List<T> list, EntryElementData data, Dictionary<string, T> lookupDictionary)
        {
            list.Add(lookupDictionary[data.Content]);
        }

        private static void AddGloss(List<Gloss> list, EntryElementData data)
        {
            list.Add(new Gloss(data.Content, Languages[data.LanguageAttribute], data.GlossGenderAttribute));
        }

        private static void AddLoanwordGloss(List<LoanwordGloss> list, EntryElementData data)
        {
            list.Add(new LoanwordGloss(data.Content, Languages[data.LanguageAttribute], data.GlossGenderAttribute, data.LoanwordTypeAttribute != null, data.LoanwordWaseiAttribute != null));
        }
    }
}
