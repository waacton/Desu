namespace Wacton.Desu.Kanji
{
    using System.Threading.Tasks;
    using System.Xml;

    internal class CharacterElementData
    {
        private const string CodepointTypeTag = "cp_type";
        private const string RadicalTypeTag = "rad_type";
        private const string VariantTypeTag = "var_type";
        private const string ReferenceTypeTag = "dr_type";
        private const string ReferenceVolumeTag = "m_vol";
        private const string ReferencePageTag = "m_page";
        private const string QueryCodeTypeTag = "qc_type";
        private const string SkipMisclassificationTag = "skip_misclass";
        private const string ReadingTypeTag = "r_type";
        private const string LanguageTag = "m_lang";

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

        public static async Task<CharacterElementData> FromXmlReaderAsync(XmlReader reader)
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
                Content = await reader.ReadElementContentAsStringAsync()
            };

            return characterElementData;
        }

        public override string ToString() => Content;
    }
}
