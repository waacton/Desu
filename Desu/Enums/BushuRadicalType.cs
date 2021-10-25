namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/wiki/index.php/KANJIDIC_Project#Content_.26_Format (radical)
    public class BushuRadicalType : Enumeration
    {
        public static readonly BushuRadicalType Classical = new BushuRadicalType(nameof(Classical), "classical");
        public static readonly BushuRadicalType Nelson = new BushuRadicalType(nameof(Nelson), "nelson_c");

        public string Code { get; }

        public BushuRadicalType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
