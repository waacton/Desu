namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/wiki/index.php/KANJIDIC_Project#Content_.26_Format (radical)
    public class IndexRadicalType : Enumeration
    {
        public static readonly IndexRadicalType Kangxi = new IndexRadicalType(nameof(Kangxi), "classical");
        public static readonly IndexRadicalType Nelson = new IndexRadicalType(nameof(Nelson), "nelson_c");

        public string Code { get; }

        public IndexRadicalType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
