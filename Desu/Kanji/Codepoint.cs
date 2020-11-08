namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
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

        public override bool Equals(object obj)
        {
            return obj is Codepoint codepoint &&
                   EqualityComparer<CodepointType>.Default.Equals(Type, codepoint.Type) &&
                   Value == codepoint.Value;
        }
    }
}