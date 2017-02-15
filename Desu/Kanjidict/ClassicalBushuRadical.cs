namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class ClassicalBushuRadical : Enumeration, IBushuRadical
    {
        public static readonly ClassicalBushuRadical Radical001 = new ClassicalBushuRadical("Radical001", 1, "一");
        public static readonly ClassicalBushuRadical Radical002 = new ClassicalBushuRadical("Radical002", 2, "丨");
        public static readonly ClassicalBushuRadical Radical003 = new ClassicalBushuRadical("Radical003", 3, "丶");
        public static readonly ClassicalBushuRadical Radical004 = new ClassicalBushuRadical("Radical004", 4, "丿");
        public static readonly ClassicalBushuRadical Radical005 = new ClassicalBushuRadical("Radical005", 5, "乙");
        public static readonly ClassicalBushuRadical Radical006 = new ClassicalBushuRadical("Radical006", 6, "亅");
        public static readonly ClassicalBushuRadical Radical007 = new ClassicalBushuRadical("Radical007", 7, "二");

        public BushuRadicalType Type => BushuRadicalType.Classical;
        public int Number { get; }
        public string Radical { get; }

        public ClassicalBushuRadical(string displayName, int number, string radical)
            : base(displayName)
        {
            this.Radical = radical;
            this.Number = number;
        }

        public override string ToString()
        {
            return $"{this.Type} #{this.Number} ({this.Radical})";
        }
    }
}