namespace Wacton.Desu.Enums
{
    public class KanjiInformation : Enumeration
    {
        public static readonly KanjiInformation AtejiPhonetic = new KanjiInformation("AtejiPhonetic", "ateji (phonetic) reading");
        public static readonly KanjiInformation IrregularKana = new KanjiInformation("IrregularKana", "word containing irregular kana usage");
        public static readonly KanjiInformation IrregularKanji = new KanjiInformation("IrregularKanji", "word containing irregular kanji usage");
        public static readonly KanjiInformation IrregularOkurigana = new KanjiInformation("IrregularOkurigana", "irregular okurigana usage");
        public static readonly KanjiInformation OutdatedKanji = new KanjiInformation("OutdatedKanji", "word containing out-dated kanji");

        public string Code { get; }

        public KanjiInformation(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
