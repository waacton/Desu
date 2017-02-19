namespace Wacton.Desu.Kanjidict
{
    public class Reference : IReference
    {
        public ReferenceType Type { get; }

        public string Value { get; }

        public Reference(ReferenceType referenceType, string value)
        {
            this.Type = referenceType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }
    }
}