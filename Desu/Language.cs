namespace Wacton.Desu
{
    using Wacton.Tovarisch.Enum;

    public class Language : Enumeration
    {
        public static readonly Language Afrikaans = new Language("Afrikaans", "afr");
        public static readonly Language Ainu = new Language("Ainu", "ain");
        public static readonly Language Algonquin = new Language("Algonquin", "alg");
        public static readonly Language Amharic = new Language("Amharic", "amh");
        public static readonly Language Arabic = new Language("Arabic", "ara");
        public static readonly Language Bantu = new Language("Bantu", "bnt");
        public static readonly Language Breton = new Language("Breton", "bre");
        public static readonly Language Burmese = new Language("Burmese", "bur");
        public static readonly Language Chinese = new Language("Chinese", "chi");
        public static readonly Language Chinook = new Language("Chinook", "chn");
        public static readonly Language Danish = new Language("Danish", "dan");
        public static readonly Language Dutch = new Language("Dutch", "dut");
        public static readonly Language English = new Language("English", "eng");
        public static readonly Language Esperanto = new Language("Esperanto", "epo");
        public static readonly Language Estonian = new Language("Estonian", "est");
        public static readonly Language Filipino = new Language("Filipino", "fil");
        public static readonly Language Finnish = new Language("Finnish", "fin");
        public static readonly Language French = new Language("French", "fre");
        public static readonly Language German = new Language("German", "ger");
        public static readonly Language Greek = new Language("Greek", "gre");
        public static readonly Language Hawaiian = new Language("Hawaiian", "haw");
        public static readonly Language Hebrew = new Language("Hebrew", "heb");
        public static readonly Language Hindi = new Language("Hindi", "hin");
        public static readonly Language Hungarian = new Language("Hungarian", "hun");
        public static readonly Language Indonesian = new Language("Indonesian", "ind");
        public static readonly Language Italian = new Language("Italian", "ita");
        public static readonly Language KhmerCentral = new Language("KhmerCentral", "khm");
        public static readonly Language Korean = new Language("Korean", "kor");
        public static readonly Language Kurdish = new Language("Kurdish", "kur");
        public static readonly Language Latin = new Language("Latin", "lat");
        public static readonly Language Malayalam = new Language("Malayalam", "mal");
        public static readonly Language Malay = new Language("Malay", "may");
        public static readonly Language Manchu = new Language("Manchu", "mnc");
        public static readonly Language Maori = new Language("Maori", "mao");
        public static readonly Language Mongolian = new Language("Mongolian", "mon");
        public static readonly Language Norwegian = new Language("Norwegian", "nor");
        public static readonly Language Ottoman = new Language("Ottoman", "ota");
        public static readonly Language Persian = new Language("Persian", "per");
        public static readonly Language Polish = new Language("Polish", "pol");
        public static readonly Language Portuguese = new Language("Portuguese", "por");
        public static readonly Language Russian = new Language("Russian", "rus");
        public static readonly Language Sanskrit = new Language("Sanskrit", "san");
        public static readonly Language Slovenian = new Language("Slovenian", "slv");
        public static readonly Language Somali = new Language("Somali", "som");
        public static readonly Language Spanish = new Language("Spanish", "spa");
        public static readonly Language Swedish = new Language("Swedish", "swe");
        public static readonly Language Tahitian = new Language("Tahitian", "tah");
        public static readonly Language Tamil = new Language("Tamil", "tam");
        public static readonly Language Thai = new Language("Thai", "tha");
        public static readonly Language Tibetan = new Language("Tibetan", "tib");
        public static readonly Language Turkish = new Language("Turkish", "tur");
        public static readonly Language Urdu = new Language("Urdu", "urd");
        public static readonly Language Vietnamese = new Language("Vietnamese", "vie");
        public static readonly Language Yiddish = new Language("Yiddish", "yid");

        public string Code { get; }

        public Language(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
