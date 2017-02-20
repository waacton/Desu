namespace Wacton.Desu.Enums
{
    using Wacton.Tovarisch.Enum;

    public class Miscellaneous : Enumeration
    {
        public static readonly Miscellaneous Abbreviation = new Miscellaneous("Abbreviation", "abbreviation");
        public static readonly Miscellaneous Archaism = new Miscellaneous("Archaism", "archaism");
        public static readonly Miscellaneous Childrens = new Miscellaneous("Childrens", "children's language");
        public static readonly Miscellaneous Colloquialism = new Miscellaneous("Colloquialism", "colloquialism");
        public static readonly Miscellaneous Derogatory = new Miscellaneous("Derogatory", "derogatory");
        public static readonly Miscellaneous Familiar = new Miscellaneous("Familiar", "familiar language");
        public static readonly Miscellaneous Female = new Miscellaneous("Female", "female term or language");
        public static readonly Miscellaneous Honorific = new Miscellaneous("Honorific", "honorific or respectful (sonkeigo) language");
        public static readonly Miscellaneous Humble = new Miscellaneous("Humble", "humble (kenjougo) language");
        public static readonly Miscellaneous Idiomatic = new Miscellaneous("Idiomatic", "idiomatic expression");
        public static readonly Miscellaneous Jocular = new Miscellaneous("Jocular", "jocular, humorous term");
        public static readonly Miscellaneous Male = new Miscellaneous("Male", "male term or language");
        public static readonly Miscellaneous Manga = new Miscellaneous("Manga", "manga slang");
        public static readonly Miscellaneous Obscure = new Miscellaneous("Obscure", "obscure term");
        public static readonly Miscellaneous Obsolete = new Miscellaneous("Obsolete", "obsolete term");
        public static readonly Miscellaneous Onomatopoeic = new Miscellaneous("Onomatopoeic", "onomatopoeic or mimetic word");
        public static readonly Miscellaneous Poetical = new Miscellaneous("Poetical", "poetical term");
        public static readonly Miscellaneous Polite = new Miscellaneous("Polite", "polite (teineigo) language");
        public static readonly Miscellaneous Proverb = new Miscellaneous("Proverb", "proverb");
        public static readonly Miscellaneous Rare = new Miscellaneous("Rare", "rare");
        public static readonly Miscellaneous Sensitive = new Miscellaneous("Sensitive", "sensitive");
        public static readonly Miscellaneous Slang = new Miscellaneous("Slang", "slang");
        public static readonly Miscellaneous Vulgar = new Miscellaneous("Vulgar", "vulgar expression or word");
        public static readonly Miscellaneous UsuallyKanaAlone = new Miscellaneous("UsuallyKanaAlone", "word usually written using kana alone");
        public static readonly Miscellaneous Yojijukugo = new Miscellaneous("Yojijukugo", "yojijukugo");

        public string Code { get; }

        public Miscellaneous(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
