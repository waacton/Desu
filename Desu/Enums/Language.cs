namespace Wacton.Desu.Enums
{
    // http://edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr

    public class Language : Enumeration
    {
        public static readonly Language Afrikaans = new Language("Afrikaans", "afr", "af");
        public static readonly Language Ainu = new Language("Ainu", "ain");
        public static readonly Language Algonquin = new Language("Algonquin", "alg");
        public static readonly Language Amharic = new Language("Amharic", "amh", "am");
        public static readonly Language Arabic = new Language("Arabic", "ara", "ar");
        public static readonly Language Bantu = new Language("Bantu", "bnt");
        public static readonly Language Breton = new Language("Breton", "bre", "br");
        public static readonly Language Bulgarian = new Language("Bulgarian", "bul", "bg");
        public static readonly Language Burmese = new Language("Burmese", "bur", "my");
        public static readonly Language Chinese = new Language("Chinese", "chi", "zh");
        public static readonly Language Chinook = new Language("Chinook", "chn");
        public static readonly Language Croatian = new Language("Croatian", "scr", "hr");
        public static readonly Language Czech = new Language("Czech", "cze", "cs");
        public static readonly Language Danish = new Language("Danish", "dan", "da");
        public static readonly Language Dutch = new Language("Dutch", "dut", "nl");
        public static readonly Language English = new Language("English", "eng", "en");
        public static readonly Language Esperanto = new Language("Esperanto", "epo", "eo");
        public static readonly Language Estonian = new Language("Estonian", "est", "et");
        public static readonly Language Filipino = new Language("Filipino", "fil");
        public static readonly Language Finnish = new Language("Finnish", "fin", "fi");
        public static readonly Language French = new Language("French", "fre", "fr");
        public static readonly Language Galician = new Language("Galician", "glg", "gl");
        public static readonly Language German = new Language("German", "ger", "de");
        public static readonly Language Georgian = new Language("Georgian", "geo", "ka");
        public static readonly Language Greek = new Language("Greek", "gre", "el");
        public static readonly Language GreekAncient = new Language("GreekAncient", "grc");
        public static readonly Language Hawaiian = new Language("Hawaiian", "haw");
        public static readonly Language Hebrew = new Language("Hebrew", "heb", "he");
        public static readonly Language Hindi = new Language("Hindi", "hin", "hi");
        public static readonly Language Hungarian = new Language("Hungarian", "hun", "hu");
        public static readonly Language Icelandic = new Language("Icelandic", "ice", "is");
        public static readonly Language Indonesian = new Language("Indonesian", "ind", "id");
        public static readonly Language Italian = new Language("Italian", "ita", "it");
        public static readonly Language KhmerCentral = new Language("KhmerCentral", "khm", "km");
        public static readonly Language Korean = new Language("Korean", "kor", "ko");
        public static readonly Language Kurdish = new Language("Kurdish", "kur", "ku");
        public static readonly Language Latin = new Language("Latin", "lat", "la");
        public static readonly Language Malayalam = new Language("Malayalam", "mal", "ml");
        public static readonly Language Malay = new Language("Malay", "may", "ms");
        public static readonly Language Manchu = new Language("Manchu", "mnc");
        public static readonly Language Maori = new Language("Maori", "mao", "mi");
        public static readonly Language Moldavian = new Language("Moldavian", "mol", "mo");
        public static readonly Language Mongolian = new Language("Mongolian", "mon", "mn");
        public static readonly Language Mapudungun = new Language("Mapudungun", "arn");
        public static readonly Language Norwegian = new Language("Norwegian", "nor", "no");
        public static readonly Language Persian = new Language("Persian", "per", "fa");
        public static readonly Language Polish = new Language("Polish", "pol", "pl");
        public static readonly Language Portuguese = new Language("Portuguese", "por", "pt");
        public static readonly Language Romanian = new Language("Romanian", "rum", "ro");
        public static readonly Language Russian = new Language("Russian", "rus", "ru");
        public static readonly Language Sanskrit = new Language("Sanskrit", "san", "sa");
        public static readonly Language Slovak = new Language("Slovak", "slo", "sk");
        public static readonly Language Slovenian = new Language("Slovenian", "slv", "sl");
        public static readonly Language Somali = new Language("Somali", "som", "so");
        public static readonly Language Spanish = new Language("Spanish", "spa", "es");
        public static readonly Language Swahili = new Language("Swahili", "swa", "sw");
        public static readonly Language Swedish = new Language("Swedish", "swe", "sv");
        public static readonly Language Tahitian = new Language("Tahitian", "tah", "ty");
        public static readonly Language Tamil = new Language("Tamil", "tam", "ta");
        public static readonly Language Thai = new Language("Thai", "tha", "th");
        public static readonly Language Tibetan = new Language("Tibetan", "tib", "bo");
        public static readonly Language Turkish = new Language("Turkish", "tur", "tr");
        public static readonly Language Urdu = new Language("Urdu", "urd", "ur");
        public static readonly Language Vietnamese = new Language("Vietnamese", "vie", "vi");
        public static readonly Language Yiddish = new Language("Yiddish", "yid", "yi");

        public string ThreeLetterCode { get; }
        public string TwoLetterCode { get; }

        public Language(string displayName, string threeLetterCode, string twoLetterCode = null)
            : base(displayName)
        {
            this.ThreeLetterCode = threeLetterCode;
            this.TwoLetterCode = twoLetterCode;
        }
    }
}
