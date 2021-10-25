namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Kinf)
    public class KanjiInformation : Enumeration
    {
        public static readonly KanjiInformation AtejiPhonetic = new KanjiInformation(nameof(AtejiPhonetic), "ateji (phonetic) reading");
        public static readonly KanjiInformation IrregularKana = new KanjiInformation(nameof(IrregularKana), "word containing irregular kana usage");
        public static readonly KanjiInformation IrregularKanji = new KanjiInformation(nameof(IrregularKanji), "word containing irregular kanji usage");
        public static readonly KanjiInformation IrregularOkurigana = new KanjiInformation(nameof(IrregularOkurigana), "irregular okurigana usage");
        public static readonly KanjiInformation OutdatedKanji = new KanjiInformation(nameof(OutdatedKanji), "word containing out-dated kanji or kanji usage");

        public string Code { get; }

        public KanjiInformation(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
