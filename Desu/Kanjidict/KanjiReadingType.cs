namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class KanjiReadingType : Enumeration
    {
        public static readonly KanjiReadingType Pinyin = new KanjiReadingType("Pinyin", "pinyin");
        public static readonly KanjiReadingType KoreanRomanized = new KanjiReadingType("KoreanRomanized", "korean_r");
        public static readonly KanjiReadingType KoreanHangul = new KanjiReadingType("KoreanHangul", "korean_h");
        public static readonly KanjiReadingType JapaneseOn = new KanjiReadingType("JapaneseOn", "ja_on");
        public static readonly KanjiReadingType JapaneseKun = new KanjiReadingType("JapaneseKun", "ja_kun");

        public string Code { get; }

        public KanjiReadingType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
