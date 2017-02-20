namespace Wacton.Desu.Enums
{
    using Wacton.Tovarisch.Enum;

    public class ReferenceType : Enumeration
    {
        public static readonly ReferenceType Nelson_Classic = new ReferenceType("Nelson: \"Modern Reader's Japanese-English Character Dictionary\"", "nelson_c");
        public static readonly ReferenceType Nelson_New = new ReferenceType("Nelson: \"The New Nelson Japanese-English Character Dictionary\"", "nelson_n");
        public static readonly ReferenceType Halpern_NJECD = new ReferenceType("Halpern: \"New Japanese-English Character Dictionary\"", "halpern_njecd");
        public static readonly ReferenceType Halpern_KLD = new ReferenceType("Halpern: \"Kanji Learners Dictionary\"", "halpern_kkld");
        public static readonly ReferenceType Halpern_KLD_2 = new ReferenceType("Halpern: \"Kanji Learners Dictionary\", 2nd Edition", "halpern_kkld_2ed");
        public static readonly ReferenceType Halpern_KKD = new ReferenceType("Halpern: \"Kodansha Kanji Dictionary\"", "halpern_kkd");
        public static readonly ReferenceType Heisig = new ReferenceType("Heisig: \"Remembering The Kanji\"", "heisig");
        public static readonly ReferenceType Heisig_6 = new ReferenceType("Heisig: \"Remembering The Kanji\", 6th Edition", "heisig6");
        public static readonly ReferenceType Gakken = new ReferenceType("Gakken: \"A New Dictionary Of Kanji Usage\"", "gakken");
        public static readonly ReferenceType ONeill_Names = new ReferenceType("O'Neill: \"Japanese Names\"", "oneill_names");
        public static readonly ReferenceType ONeill_Kanji = new ReferenceType("O'Neill: \"Essential Kanji\"", "oneill_kk");
        public static readonly ReferenceType Morohashi = new ReferenceType("Morohashi: \"Daikanwajiten\"", "moro");
        public static readonly ReferenceType Henshall = new ReferenceType("Henshall: \"A Guide To Remembering Japanese Characters\"", "henshall");
        public static readonly ReferenceType SpahnHadamitzky = new ReferenceType("Spahn & Hadamitzky: \"The Kanji Dictionary\"", "sh_kk");
        public static readonly ReferenceType SpahnHadamitzky_2 = new ReferenceType("Spahn & Hadamitzky: \"The Kanji Dictionary\", 2nd Edition", "sh_kk2");
        public static readonly ReferenceType Sakade = new ReferenceType("Sakade: \"A Guide To Reading And Writing Japanese\"", "sakade");
        public static readonly ReferenceType JapaneseFlashcards = new ReferenceType("Japanese Kanji Flashcards (Hodges & Okazaki)", "jf_cards");
        public static readonly ReferenceType HenshallSeeleyDeGroot = new ReferenceType("Henshall, Seeley & De Groot: \"A Guide To Reading And Writing Japanese\", 3rd Edition", "henshall3");
        public static readonly ReferenceType TuttleFlashcards = new ReferenceType("Tuttle Flash Cards (Kask)", "tutt_cards");
        public static readonly ReferenceType Crowley = new ReferenceType("Crowley: \"The Kanji Way to Japanese Language Power\"", "crowley");
        public static readonly ReferenceType KanjiContext = new ReferenceType("Nishiguchi & Kono: \"Kanji In Context\"", "kanji_in_context");
        public static readonly ReferenceType BusyPeople = new ReferenceType("AJALT: \"Japanese For Busy People\"", "busy_people");
        public static readonly ReferenceType KodenshaCompact = new ReferenceType("\"Kodansha's Compact Kanji Guide\"", "kodansha_compact");
        public static readonly ReferenceType Maniette = new ReferenceType("Maniette: \"Les Kanjis Dans La Tête\"", "maniette");

        public string Code { get; }

        public ReferenceType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
