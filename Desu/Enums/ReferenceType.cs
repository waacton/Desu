namespace Wacton.Desu.Enums
{
    public class ReferenceType : Enumeration
    {
        public static readonly ReferenceType Nelson_Classic = new ReferenceType(nameof(Nelson_Classic), "nelson_c", "Nelson: \"Modern Reader's Japanese-English Character Dictionary\"");
        public static readonly ReferenceType Nelson_New = new ReferenceType(nameof(Nelson_New), "nelson_n", "Nelson: \"The New Nelson Japanese-English Character Dictionary\"");
        public static readonly ReferenceType Halpern_NJECD = new ReferenceType(nameof(Halpern_NJECD), "halpern_njecd", "Halpern: \"New Japanese-English Character Dictionary\"");
        public static readonly ReferenceType Halpern_KLD = new ReferenceType(nameof(Halpern_KLD), "halpern_kkld", "Halpern: \"Kanji Learners Dictionary\"");
        public static readonly ReferenceType Halpern_KLD_2 = new ReferenceType(nameof(Halpern_KLD_2), "halpern_kkld_2ed", "Halpern: \"Kanji Learners Dictionary\", 2nd Edition");
        public static readonly ReferenceType Halpern_KKD = new ReferenceType(nameof(Halpern_KKD), "halpern_kkd", "Halpern: \"Kodansha Kanji Dictionary\"");
        public static readonly ReferenceType Heisig = new ReferenceType(nameof(Heisig), "heisig", "Heisig: \"Remembering The Kanji\"");
        public static readonly ReferenceType Heisig_6 = new ReferenceType(nameof(Heisig_6), "heisig6", "Heisig: \"Remembering The Kanji\", 6th Edition");
        public static readonly ReferenceType Gakken = new ReferenceType(nameof(Gakken), "gakken", "Gakken: \"A New Dictionary Of Kanji Usage\"");
        public static readonly ReferenceType ONeill_Names = new ReferenceType(nameof(ONeill_Names), "oneill_names", "O'Neill: \"Japanese Names\"");
        public static readonly ReferenceType ONeill_Kanji = new ReferenceType(nameof(ONeill_Kanji), "oneill_kk", "O'Neill: \"Essential Kanji\"");
        public static readonly ReferenceType Morohashi = new ReferenceType(nameof(Morohashi), "moro", "Morohashi: \"Daikanwajiten\"");
        public static readonly ReferenceType Henshall = new ReferenceType(nameof(Henshall), "henshall", "Henshall: \"A Guide To Remembering Japanese Characters\"");
        public static readonly ReferenceType SpahnHadamitzky = new ReferenceType(nameof(SpahnHadamitzky), "sh_kk", "Spahn & Hadamitzky: \"The Kanji Dictionary\"");
        public static readonly ReferenceType SpahnHadamitzky_2 = new ReferenceType(nameof(SpahnHadamitzky_2), "sh_kk2", "Spahn & Hadamitzky: \"The Kanji Dictionary\", 2nd Edition");
        public static readonly ReferenceType Sakade = new ReferenceType(nameof(Sakade), "sakade", "Sakade: \"A Guide To Reading And Writing Japanese\"");
        public static readonly ReferenceType JapaneseFlashcards = new ReferenceType(nameof(JapaneseFlashcards), "jf_cards", "Japanese Kanji Flashcards (Hodges & Okazaki)");
        public static readonly ReferenceType HenshallSeeleyDeGroot = new ReferenceType(nameof(HenshallSeeleyDeGroot), "henshall3", "Henshall, Seeley & De Groot: \"A Guide To Reading And Writing Japanese\", 3rd Edition");
        public static readonly ReferenceType TuttleFlashcards = new ReferenceType(nameof(TuttleFlashcards), "tutt_cards", "Tuttle Flash Cards (Kask)");
        public static readonly ReferenceType Crowley = new ReferenceType(nameof(Crowley), "crowley", "Crowley: \"The Kanji Way to Japanese Language Power\"");
        public static readonly ReferenceType KanjiContext = new ReferenceType(nameof(KanjiContext), "kanji_in_context", "Nishiguchi & Kono: \"Kanji In Context\"");
        public static readonly ReferenceType BusyPeople = new ReferenceType(nameof(BusyPeople), "busy_people", "AJALT: \"Japanese For Busy People\"");
        public static readonly ReferenceType KodenshaCompact = new ReferenceType(nameof(KodenshaCompact), "kodansha_compact", "\"Kodansha's Compact Kanji Guide\"");
        public static readonly ReferenceType Maniette = new ReferenceType(nameof(Maniette), "maniette", "Maniette: \"Les Kanjis Dans La Tête\"");

        public string Code { get; }
        public string Description { get; }

        public ReferenceType(string displayName, string code, string description)
            : base(displayName)
        {
            this.Code = code;
            this.Description = description;
        }

        public override string ToString() => this.Description;
    }
}
