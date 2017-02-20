namespace Wacton.Desu.Enums
{
    using Wacton.Tovarisch.Enum;

    public class QueryCodeType : Enumeration
    {
        public static readonly QueryCodeType SKIP = new QueryCodeType("SKIP", "skip");
        public static readonly QueryCodeType SpahnHadamitzky = new QueryCodeType("Spahn & Hadamitzky", "sh_desc");
        public static readonly QueryCodeType FourCorner = new QueryCodeType("Four Corner", "four_corner");
        public static readonly QueryCodeType DeRoo = new QueryCodeType("De Roo", "deroo");

        public string Code { get; }

        public QueryCodeType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
