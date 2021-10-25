namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/wiki/index.php/KANJIDIC_Project#Content_.26_Format (query_code)
    public class QueryCodeType : Enumeration
    {
        public static readonly QueryCodeType SKIP = new QueryCodeType(nameof(SKIP), "skip", "SKIP");
        public static readonly QueryCodeType SpahnHadamitzky = new QueryCodeType(nameof(SpahnHadamitzky), "sh_desc", "Spahn & Hadamitzky");
        public static readonly QueryCodeType FourCorner = new QueryCodeType(nameof(FourCorner), "four_corner", "Four Corner");
        public static readonly QueryCodeType DeRoo = new QueryCodeType(nameof(DeRoo), "deroo", "De Roo");

        public string Code { get; }
        public string Description { get; }

        public QueryCodeType(string displayName, string code, string description)
            : base(displayName)
        {
            this.Code = code;
            this.Description = description;
        }

        public override string ToString() => this.Description;
    }
}
