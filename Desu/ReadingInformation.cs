namespace Wacton.Desu
{
    using Wacton.Tovarisch.Enum;

    public class ReadingInformation : Enumeration
    {
        public static readonly ReadingInformation GikunOrJukujikun = new ReadingInformation("GikunOrJukujikun", "gikun (meaning as reading) or jukujikun (special kanji reading)");
        public static readonly ReadingInformation IrregularKana = new ReadingInformation("IrregularKana", "word containing irregular kana usage");
        public static readonly ReadingInformation OutdatedKana = new ReadingInformation("OutdatedKana", "out-dated or obsolete kana usage");

        public string Code { get; }

        public ReadingInformation(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
