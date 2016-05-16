namespace Wacton.Desu
{
    using Wacton.Tovarisch.Enum;

    public class KanjiInformation : Enumeration
    {
        public static readonly KanjiInformation AtejiPhonetic = new KanjiInformation("AtejiPhonetic", "ateji (phonetic) reading");
        public static readonly KanjiInformation IrregularKana = new KanjiInformation("IrregularKana", "word containing irregular kana usage");
        public static readonly KanjiInformation IrregularKanji = new KanjiInformation("IrregularKanji", "word containing irregular kanji usage");
        public static readonly KanjiInformation IrregularOkurigana = new KanjiInformation("IrregularOkurigana", "irregular okurigana usage");
        public static readonly KanjiInformation OutdatedKanji = new KanjiInformation("OutdatedKanji", "word containing out-dated kanji");

        public string Code { get; }

        private static int counter;
        public KanjiInformation(string displayName, string code)
            : base(counter++, displayName)
        {
            this.Code = code;
        }
    }
}
