namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class BushuRadicalType : Enumeration
    {
        public static readonly BushuRadicalType Classical = new BushuRadicalType("Classical KangXi Zidian", "classical");
        public static readonly BushuRadicalType Nelson = new BushuRadicalType("Nelson", "nelson_c");

        public string Code { get; }

        public BushuRadicalType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
