namespace Wacton.Desu.Enums
{
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
