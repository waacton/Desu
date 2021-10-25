namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Ginf)
    public class GlossType : Enumeration
    {
        public static readonly GlossType Explanation = new GlossType(nameof(Explanation), "expl");
        public static readonly GlossType Figurative = new GlossType(nameof(Figurative), "fig");
        public static readonly GlossType Literal = new GlossType(nameof(Literal), "lit");
        public static readonly GlossType Trademark = new GlossType(nameof(Trademark), "tm");

        public string Code { get; }

        public GlossType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
