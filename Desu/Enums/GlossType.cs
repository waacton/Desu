namespace Wacton.Desu.Enums
{
    public class GlossType : Enumeration
    {
        public static readonly GlossType Literal = new GlossType(nameof(Literal), "lit");
        public static readonly GlossType Figurative = new GlossType(nameof(Figurative), "fig");
        public static readonly GlossType Explanation = new GlossType(nameof(Explanation), "expl");

        public string Code { get; }

        public GlossType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
