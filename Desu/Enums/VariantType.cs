namespace Wacton.Desu.Enums
{
    public class VariantType : Enumeration
    {
        public static readonly VariantType JIS208 = new VariantType(nameof(JIS208), "jis208", "JIS X 0208");
        public static readonly VariantType JIS212 = new VariantType(nameof(JIS212), "jis212", "JIS X 0212");
        public static readonly VariantType JIS213 = new VariantType(nameof(JIS213), "jis213", "JIS X 0213");
        public static readonly VariantType DeRoo = new VariantType(nameof(DeRoo), "deroo", "De Roo");
        public static readonly VariantType Halpern_NJECD = new VariantType(nameof(Halpern_NJECD), "njecd", "Halpern: \"New Japanese-English Character Dictionary\"");
        public static readonly VariantType SpahnHadamitzky = new VariantType(nameof(SpahnHadamitzky), "s_h", "Spahn & Hadamitzky: \"The Kanji Dictionary\" ");
        public static readonly VariantType Nelson_Classic = new VariantType(nameof(Nelson_Classic), "nelson_c", "Nelson: \"Modern Reader's Japanese-English Character Dictionary\"");
        public static readonly VariantType ONeill_Names = new VariantType(nameof(ONeill_Names), "oneill", "O'Neill: \"Japanese Names\"");
        public static readonly VariantType Unicode = new VariantType(nameof(Unicode), "ucs", "Unicode");

        public string Code { get; }
        public string Description { get; }

        public VariantType(string displayName, string code, string description)
            : base(displayName)
        {
            this.Code = code;
            this.Description = description;
        }

        public override string ToString() => this.Description;
    }
}
