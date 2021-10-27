namespace Wacton.Desu.Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    // TODO: ke_inf, ke_pri, re_restr, re_inf, re_pri are all currently unused in the Name dictionary (though they are used in the Japanese dictionary)
    // - consider either removing them, or merging the two IKanji/IReading objects together
    internal class EntryElement : Enumeration
    {
        public static readonly EntryElement Sequence = new EntryElement("Sequence", "ent_seq", (entry, data) => entry.Sequence = int.Parse(data.Content));

        public static readonly EntryElement Kanji = new EntryElement("Kanji", "k_ele", (entry, data) => entry.StartNewKanji(), false);
        public static readonly EntryElement KanjiText = new EntryElement("KanjiText", "keb", (entry, data) => entry.KanjisList.Last().Text = data.Content);
        public static readonly EntryElement KanjiInformation = new EntryElement("KanjiInformation", "ke_inf", (entry, data) => AddContent(entry.KanjisList.Last().InformationsList, data, KanjiInformations));
        public static readonly EntryElement KanjiPriority = new EntryElement("KanjiPriority", "ke_pri", (entry, data) => AddContent(entry.KanjisList.Last().PrioritiesList, data, Priorities));

        public static readonly EntryElement Reading = new EntryElement("Reading", "r_ele", (entry, data) => entry.StartNewReading(), false);
        public static readonly EntryElement ReadingText = new EntryElement("ReadingText", "reb", (entry, data) => entry.ReadingsList.Last().Text = data.Content);
        public static readonly EntryElement ReadingRestriction = new EntryElement("ReadingRestriction", "re_restr", (entry, data) => AddContent(entry.ReadingsList.Last().RestrictionList, data));
        public static readonly EntryElement ReadingInformation = new EntryElement("ReadingInformation", "re_inf", (entry, data) => AddContent(entry.ReadingsList.Last().InformationsList, data, ReadingInformations));
        public static readonly EntryElement ReadingPriority = new EntryElement("ReadingPriority", "re_pri", (entry, data) => AddContent(entry.ReadingsList.Last().PrioritiesList, data, Priorities));

        public static readonly EntryElement Translation = new EntryElement("Translation", "trans", (entry, data) => entry.StartNewTranslation(), false);
        public static readonly EntryElement NameType = new EntryElement("NameType", "name_type", (entry, data) => AddContent(entry.TranslationsList.Last().NameTypesList, data, NameTypes));
        public static readonly EntryElement CrossReference = new EntryElement("CrossReference", "xref", (entry, data) => AddContent(entry.TranslationsList.Last().CrossReferencesList, data));
        public static readonly EntryElement Transcription = new EntryElement("Transcription", "trans_det", (entry, data) => AddContent(entry.TranslationsList.Last().TranscriptionsList, data));

        private static readonly Dictionary<string, KanjiInformation> KanjiInformations = GetAll<KanjiInformation>().ToDictionary(information => information.Code, information => information);
        private static readonly Dictionary<string, NameType> NameTypes = GetAll<NameType>().ToDictionary(nameType => nameType.Code, nameType => nameType);
        private static readonly Dictionary<string, Priority> Priorities = GetAll<Priority>().ToDictionary(priority => priority.Code, priority => priority);
        private static readonly Dictionary<string, ReadingInformation> ReadingInformations = GetAll<ReadingInformation>().ToDictionary(information => information.Code, information => information);

        public string Code { get; }
        public bool ExpectsContent { get; }

        private readonly Action<NameEntry, EntryElementData> addDataToEntryAction;

        public EntryElement(string displayName, string code, Action<NameEntry, EntryElementData> addDataToEntryAction = null, bool expectsContent = true)
            : base(displayName)
        {
            Code = code;
            this.addDataToEntryAction = addDataToEntryAction ?? ((entry, data) => { });
            ExpectsContent = expectsContent;
        }

        internal void AddDataToEntry(NameEntry entry, EntryElementData data)
        {
            addDataToEntryAction(entry, data);
        }

        private static void AddContent(List<string> list, EntryElementData data)
        {
            list.Add(data.Content);
        }

        private static void AddContent<T>(List<T> list, EntryElementData data, Dictionary<string, T> lookupDictionary)
        {
            list.Add(lookupDictionary[data.Content]);
        }
    }
}
