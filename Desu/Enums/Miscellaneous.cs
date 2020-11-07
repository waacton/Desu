namespace Wacton.Desu.Enums
{
    public class Miscellaneous : Enumeration
    {
        public static readonly Miscellaneous Abbreviation = new Miscellaneous(nameof(Abbreviation), "abbreviation");
        public static readonly Miscellaneous Archaism = new Miscellaneous(nameof(Archaism), "archaism");
        public static readonly Miscellaneous Childrens = new Miscellaneous(nameof(Childrens), "children's language");
        public static readonly Miscellaneous Colloquialism = new Miscellaneous(nameof(Colloquialism), "colloquialism");
        public static readonly Miscellaneous Dated = new Miscellaneous(nameof(Dated), "dated term");
        public static readonly Miscellaneous Derogatory = new Miscellaneous(nameof(Derogatory), "derogatory");
        public static readonly Miscellaneous Familiar = new Miscellaneous(nameof(Familiar), "familiar language");
        public static readonly Miscellaneous Female = new Miscellaneous(nameof(Female), "female term or language");
        public static readonly Miscellaneous Historical = new Miscellaneous(nameof(Historical), "historical term");
        public static readonly Miscellaneous Honorific = new Miscellaneous(nameof(Honorific), "honorific or respectful (sonkeigo) language");
        public static readonly Miscellaneous Humble = new Miscellaneous(nameof(Humble), "humble (kenjougo) language");
        public static readonly Miscellaneous Idiomatic = new Miscellaneous(nameof(Idiomatic), "idiomatic expression");
        public static readonly Miscellaneous Internet = new Miscellaneous(nameof(Internet), "Internet slang");
        public static readonly Miscellaneous Jocular = new Miscellaneous(nameof(Jocular), "jocular, humorous term");
        public static readonly Miscellaneous Literary = new Miscellaneous(nameof(Literary), "literary or formal term");
        public static readonly Miscellaneous Male = new Miscellaneous(nameof(Male), "male term or language");
        public static readonly Miscellaneous Manga = new Miscellaneous(nameof(Manga), "manga slang");
        public static readonly Miscellaneous Obscure = new Miscellaneous(nameof(Obscure), "obscure term");
        public static readonly Miscellaneous Obsolete = new Miscellaneous(nameof(Obsolete), "obsolete term");
        public static readonly Miscellaneous Onomatopoeic = new Miscellaneous(nameof(Onomatopoeic), "onomatopoeic or mimetic word");
        public static readonly Miscellaneous Person = new Miscellaneous(nameof(Person), "full name of a particular person");
        public static readonly Miscellaneous Place = new Miscellaneous(nameof(Place), "place name");
        public static readonly Miscellaneous Poetical = new Miscellaneous(nameof(Poetical), "poetical term");
        public static readonly Miscellaneous Polite = new Miscellaneous(nameof(Polite), "polite (teineigo) language");
        public static readonly Miscellaneous Proverb = new Miscellaneous(nameof(Proverb), "proverb");
        public static readonly Miscellaneous Quotation = new Miscellaneous(nameof(Quotation), "quotation");
        public static readonly Miscellaneous Rare = new Miscellaneous(nameof(Rare), "rare");
        public static readonly Miscellaneous Sensitive = new Miscellaneous(nameof(Sensitive), "sensitive");
        public static readonly Miscellaneous Slang = new Miscellaneous(nameof(Slang), "slang");
        public static readonly Miscellaneous UsuallyKanaAlone = new Miscellaneous(nameof(UsuallyKanaAlone), "word usually written using kana alone");
        public static readonly Miscellaneous Vulgar = new Miscellaneous(nameof(Vulgar), "vulgar expression or word");
        public static readonly Miscellaneous Work = new Miscellaneous(nameof(Work), "work of art, literature, music, etc. name");
        public static readonly Miscellaneous Yojijukugo = new Miscellaneous(nameof(Yojijukugo), "yojijukugo");

        public string Code { get; }

        public Miscellaneous(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
