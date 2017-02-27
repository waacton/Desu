namespace Wacton.Desu.Enums
{
    public class CodepointType : Enumeration
    {
        public static readonly CodepointType JIS208 = new CodepointType("JIS X 0208-1997", "jis208");
        public static readonly CodepointType JIS212 = new CodepointType("JIS X 0212-1990", "jis212");
        public static readonly CodepointType JIS213 = new CodepointType("JIS X 0213-2000", "jis213");
        public static readonly CodepointType Unicode = new CodepointType("Unicode 4.0", "ucs");

        public string Code { get; }

        public CodepointType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
