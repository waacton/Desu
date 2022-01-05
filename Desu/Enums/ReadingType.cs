namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/wiki/index.php/KANJIDIC_Project#Content_.26_Format (rmgroup)
    public class ReadingType : Enumeration
    {
        public static readonly ReadingType Pinyin = new ReadingType(nameof(Pinyin), "pinyin");
        public static readonly ReadingType KoreanRomanized = new ReadingType(nameof(KoreanRomanized), "korean_r");
        public static readonly ReadingType KoreanHangul = new ReadingType(nameof(KoreanHangul), "korean_h");
        public static readonly ReadingType Vietnam = new ReadingType(nameof(Vietnam), "vietnam");
        public static readonly ReadingType JapaneseOn = new ReadingType(nameof(JapaneseOn), "ja_on");
        public static readonly ReadingType JapaneseKun = new ReadingType(nameof(JapaneseKun), "ja_kun");

        public string Code { get; }

        public ReadingType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
