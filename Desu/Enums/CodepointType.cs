namespace Wacton.Desu.Enums
{
    public class CodepointType : Enumeration
    {
        public static readonly CodepointType JIS208 = new CodepointType(nameof(JIS208), "jis208", "JIS X 0208-1997");
        public static readonly CodepointType JIS212 = new CodepointType(nameof(JIS212), "jis212", "JIS X 0212-1990");
        public static readonly CodepointType JIS213 = new CodepointType(nameof(JIS213), "jis213", "JIS X 0213-2000");
        public static readonly CodepointType Unicode = new CodepointType(nameof(Unicode), "ucs", "Unicode 4.0");

        public string Code { get; }
        public string Description { get; }

        public CodepointType(string displayName, string code, string description)
            : base(displayName)
        {
            this.Code = code;
            this.Description = description;
        }

        public override string ToString() => this.Description;
    }
}
