namespace Wacton.Desu.Kanjidict
{
    public class CharacterElementData
    {
        public string Content { get; }
        public string CodepointTypeAttribute { get; }
        public string RadicalTypeAttribute { get; }
        public string VariantTypeAttribute { get; }
        public string ReferenceTypeAttribute { get; }
        public string ReferenceVolumeAttribute { get; }
        public string ReferencePageAttribute { get; }
        public string QueryCodeTypeAttribute { get; }
        public string SkipMisclassificationAttribute { get; }
        public string ReadingTypeAttribute { get; }
        public string LanguageAttribute { get; }

        public CharacterElementData(string content, 
            string codepointTypeAttribute, string radicalTypeAttribute,
            string variantTypeAttribute, string referenceTypeAttribute, 
            string referenceVolumeAttribute, string referencePageAttribute, 
            string queryCodeTypeAttribute, string skipMisclassificationAttribute,
            string readingTypeAttribute, string languageAttribute)
        {
            this.Content = content;
            this.CodepointTypeAttribute = codepointTypeAttribute;
            this.RadicalTypeAttribute = radicalTypeAttribute;
            this.VariantTypeAttribute = variantTypeAttribute;
            this.ReferenceTypeAttribute = referenceTypeAttribute;
            this.ReferenceVolumeAttribute = referenceVolumeAttribute;
            this.ReferencePageAttribute = referencePageAttribute;
            this.QueryCodeTypeAttribute = queryCodeTypeAttribute;
            this.SkipMisclassificationAttribute = skipMisclassificationAttribute;
            this.ReadingTypeAttribute = readingTypeAttribute;
            this.LanguageAttribute = languageAttribute;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
