namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Rinf)
    public class ReadingInformation : Enumeration
    {
        public static readonly ReadingInformation GikunOrJukujikun = new ReadingInformation(nameof(GikunOrJukujikun), "gikun (meaning as reading) or jukujikun (special kanji reading)");
        public static readonly ReadingInformation IrregularKana = new ReadingInformation(nameof(IrregularKana), "word containing irregular kana usage");
        public static readonly ReadingInformation OutdatedKana = new ReadingInformation(nameof(OutdatedKana), "out-dated or obsolete kana usage");

        public string Code { get; }

        public ReadingInformation(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
