namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class VariantType : Enumeration
    {
        public static readonly VariantType JIS208 = new VariantType("JIS X 0208", "jis208");
        public static readonly VariantType JIS212 = new VariantType("JIS X 0212", "jis212");
        public static readonly VariantType JIS213 = new VariantType("JIS X 0213", "jis213");
        public static readonly VariantType DeRoo = new VariantType("De Roo", "deroo");
        public static readonly VariantType Halpern_NJECD = new VariantType("Halpern: \"New Japanese-English Character Dictionary\"", "njecd");
        public static readonly VariantType SpahnHadamitzky = new VariantType("Spahn & Hadamitzky: \"The Kanji Dictionary\" ", "s_h");
        public static readonly VariantType Nelson_Classic = new VariantType("Nelson: \"Modern Reader's Japanese-English Character Dictionary\"", "nelson_c");
        public static readonly VariantType ONeill_Names = new VariantType("O'Neill: \"Japanese Names\"", "oneill");
        public static readonly VariantType Unicode = new VariantType("Unicode", "ucs");

        public string Code { get; }

        public VariantType() : base(string.Empty) { }

        public VariantType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
