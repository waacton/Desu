namespace Wacton.Desu.Kanji
{
    using Wacton.Desu.Enums;

    public class Codepoint : ICodepoint
    {
        public CodepointType Type { get; }

        public string Value { get; }

        public Codepoint(CodepointType codepointType, string value)
        {
            this.Type = codepointType;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Type}: {this.Value}";
        }
    }
}