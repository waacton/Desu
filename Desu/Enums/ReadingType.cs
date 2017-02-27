namespace Wacton.Desu.Enums
{
    public class ReadingType : Enumeration
    {
        public static readonly ReadingType Pinyin = new ReadingType("Pinyin", "pinyin");
        public static readonly ReadingType KoreanRomanized = new ReadingType("KoreanRomanized", "korean_r");
        public static readonly ReadingType KoreanHangul = new ReadingType("KoreanHangul", "korean_h");
        public static readonly ReadingType JapaneseOn = new ReadingType("JapaneseOn", "ja_on");
        public static readonly ReadingType JapaneseKun = new ReadingType("JapaneseKun", "ja_kun");

        public string Code { get; }

        public ReadingType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
