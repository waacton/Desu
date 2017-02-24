namespace Wacton.Desu.Kanji
{
    using System.Xml;

    public class CharacterElementData
    {
        private static readonly string CodepointTypeTag = "cp_type";
        private static readonly string RadicalTypeTag = "rad_type";
        private static readonly string VariantTypeTag = "var_type";
        private static readonly string ReferenceTypeTag = "dr_type";
        private static readonly string ReferenceVolumeTag = "m_vol";
        private static readonly string ReferencePageTag = "m_page";
        private static readonly string QueryCodeTypeTag = "qc_type";
        private static readonly string SkipMisclassificationTag = "skip_misclass";
        private static readonly string ReadingTypeTag = "r_type";
        private static readonly string LanguageTag = "m_lang";

        public string Content { get; private set; }

        public string CodepointTypeAttribute { get; private set; }
        public string RadicalTypeAttribute { get; private set; }
        public string VariantTypeAttribute { get; private set; }
        public string ReferenceTypeAttribute { get; private set; }
        public string ReferenceVolumeAttribute { get; private set; }
        public string ReferencePageAttribute { get; private set; }
        public string QueryCodeTypeAttribute { get; private set; }
        public string SkipMisclassificationAttribute { get; private set; }
        public string ReadingTypeAttribute { get; private set; }
        public string LanguageAttribute { get; private set; }

        public static CharacterElementData FromXmlReader(XmlReader reader)
        {
            var characterElementData = new CharacterElementData
            {
                CodepointTypeAttribute = reader.GetAttribute(CodepointTypeTag),
                RadicalTypeAttribute = reader.GetAttribute(RadicalTypeTag),
                VariantTypeAttribute = reader.GetAttribute(VariantTypeTag),
                ReferenceTypeAttribute = reader.GetAttribute(ReferenceTypeTag),
                ReferenceVolumeAttribute = reader.GetAttribute(ReferenceVolumeTag),
                ReferencePageAttribute = reader.GetAttribute(ReferencePageTag),
                QueryCodeTypeAttribute = reader.GetAttribute(QueryCodeTypeTag),
                SkipMisclassificationAttribute = reader.GetAttribute(SkipMisclassificationTag),
                ReadingTypeAttribute = reader.GetAttribute(ReadingTypeTag),
                LanguageAttribute = reader.GetAttribute(LanguageTag),
                Content = reader.ReadElementContentAsString()
            };

            return characterElementData;
        }
        public override string ToString()
        {
            return this.Content;
        }
    }
}
