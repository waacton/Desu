namespace Wacton.Desu.Kanjidict
{
    public class CharacterElementData
    {
        public string Content { get; }
        public string CodepointTypeAttribute { get; }
        public string RadicalTypeAttribute { get; }
        public string VariantTypeAttribute { get; }
        public string LanguageAttribute { get; }

        public CharacterElementData(string content, string codepointTypeAttribute, string radicalTypeAttribute, string variantTypeAttribute, string languageAttribute)
        {
            this.Content = content;
            this.CodepointTypeAttribute = codepointTypeAttribute;
            this.RadicalTypeAttribute = radicalTypeAttribute;
            this.VariantTypeAttribute = variantTypeAttribute;

            this.LanguageAttribute = languageAttribute;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
