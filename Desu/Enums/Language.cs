namespace Wacton.Desu.Enums
{
    // for details see http://edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Lang)
    public class Language : Enumeration
    {
        public static readonly Language Afrikaans = new Language(nameof(Afrikaans), "afr", "af");
        public static readonly Language Ainu = new Language(nameof(Ainu), "ain");
        public static readonly Language Algonquin = new Language(nameof(Algonquin), "alg");
        public static readonly Language Amharic = new Language(nameof(Amharic), "amh", "am");
        public static readonly Language Arabic = new Language(nameof(Arabic), "ara", "ar");
        public static readonly Language Bantu = new Language(nameof(Bantu), "bnt");
        public static readonly Language Breton = new Language(nameof(Breton), "bre", "br");
        public static readonly Language Bulgarian = new Language(nameof(Bulgarian), "bul", "bg");
        public static readonly Language Burmese = new Language(nameof(Burmese), "bur", "my");
        public static readonly Language Chinese = new Language(nameof(Chinese), "chi", "zh");
        public static readonly Language Chinook = new Language(nameof(Chinook), "chn");
        public static readonly Language Croatian = new Language(nameof(Croatian), "scr", "hr");
        public static readonly Language Czech = new Language(nameof(Czech), "cze", "cs");
        public static readonly Language Danish = new Language(nameof(Danish), "dan", "da");
        public static readonly Language Dutch = new Language(nameof(Dutch), "dut", "nl");
        public static readonly Language English = new Language(nameof(English), "eng", "en");
        public static readonly Language Esperanto = new Language(nameof(Esperanto), "epo", "eo");
        public static readonly Language Estonian = new Language(nameof(Estonian), "est", "et");
        public static readonly Language Filipino = new Language(nameof(Filipino), "fil");
        public static readonly Language Finnish = new Language(nameof(Finnish), "fin", "fi");
        public static readonly Language French = new Language(nameof(French), "fre", "fr");
        public static readonly Language Galician = new Language(nameof(Galician), "glg", "gl");
        public static readonly Language German = new Language(nameof(German), "ger", "de");
        public static readonly Language Georgian = new Language(nameof(Georgian), "geo", "ka");
        public static readonly Language Greek = new Language(nameof(Greek), "gre", "el");
        public static readonly Language GreekAncient = new Language(nameof(GreekAncient), "grc");
        public static readonly Language Hawaiian = new Language(nameof(Hawaiian), "haw");
        public static readonly Language Hebrew = new Language(nameof(Hebrew), "heb", "he");
        public static readonly Language Hindi = new Language(nameof(Hindi), "hin", "hi");
        public static readonly Language Hungarian = new Language(nameof(Hungarian), "hun", "hu");
        public static readonly Language Icelandic = new Language(nameof(Icelandic), "ice", "is");
        public static readonly Language Indonesian = new Language(nameof(Indonesian), "ind", "id");
        public static readonly Language Italian = new Language(nameof(Italian), "ita", "it");
        public static readonly Language KhmerCentral = new Language(nameof(KhmerCentral), "khm", "km");
        public static readonly Language Korean = new Language(nameof(Korean), "kor", "ko");
        public static readonly Language Kurdish = new Language(nameof(Kurdish), "kur", "ku");
        public static readonly Language Latin = new Language(nameof(Latin), "lat", "la");
        public static readonly Language Malayalam = new Language(nameof(Malayalam), "mal", "ml");
        public static readonly Language Malay = new Language(nameof(Malay), "may", "ms");
        public static readonly Language Manchu = new Language(nameof(Manchu), "mnc");
        public static readonly Language Maori = new Language(nameof(Maori), "mao", "mi");
        public static readonly Language Moldavian = new Language(nameof(Moldavian), "mol", "mo");
        public static readonly Language Mongolian = new Language(nameof(Mongolian), "mon", "mn");
        public static readonly Language Mapudungun = new Language(nameof(Mapudungun), "arn");
        public static readonly Language Norwegian = new Language(nameof(Norwegian), "nor", "no");
        public static readonly Language Persian = new Language(nameof(Persian), "per", "fa");
        public static readonly Language Polish = new Language(nameof(Polish), "pol", "pl");
        public static readonly Language Portuguese = new Language(nameof(Portuguese), "por", "pt");
        public static readonly Language Romanian = new Language(nameof(Romanian), "rum", "ro");
        public static readonly Language Russian = new Language(nameof(Russian), "rus", "ru");
        public static readonly Language Sanskrit = new Language(nameof(Sanskrit), "san", "sa");
        public static readonly Language Slovak = new Language(nameof(Slovak), "slo", "sk");
        public static readonly Language Slovenian = new Language(nameof(Slovenian), "slv", "sl");
        public static readonly Language Somali = new Language(nameof(Somali), "som", "so");
        public static readonly Language Spanish = new Language(nameof(Spanish), "spa", "es");
        public static readonly Language Swahili = new Language(nameof(Swahili), "swa", "sw");
        public static readonly Language Swedish = new Language(nameof(Swedish), "swe", "sv");
        public static readonly Language Tahitian = new Language(nameof(Tahitian), "tah", "ty");
        public static readonly Language Tamil = new Language(nameof(Tamil), "tam", "ta");
        public static readonly Language Thai = new Language(nameof(Thai), "tha", "th");
        public static readonly Language Tibetan = new Language(nameof(Tibetan), "tib", "bo");
        public static readonly Language Turkish = new Language(nameof(Turkish), "tur", "tr");
        public static readonly Language Urdu = new Language(nameof(Urdu), "urd", "ur");
        public static readonly Language Vietnamese = new Language(nameof(Vietnamese), "vie", "vi");
        public static readonly Language Yiddish = new Language(nameof(Yiddish), "yid", "yi");

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
