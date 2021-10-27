namespace Wacton.Desu.Japanese
{
    using System.Threading.Tasks;
    using System.Xml;

    internal class EntryElementData
    {
        private const string LanguageTag = "xml:lang";
        private const string LoanwordTypeTag = "ls_type";
        private const string LoanwordWaseiTag = "ls_wasei";
        private const string GlossGenderTag = "g_gend";
        private const string GlossTypeTag = "g_type";

        public string Content { get; private set; }

        public string LanguageAttribute { get; private set; }
        public string LoanwordTypeAttribute { get; private set; }
        public string LoanwordWaseiAttribute { get; private set; }
        public string GlossGenderAttribute { get; private set; }
        public string GlossTypeAttribute { get; private set; }

        public static EntryElementData FromXmlReader(XmlReader reader)
        {
            var entryElementData = new EntryElementData
            {
                LanguageAttribute = reader.GetAttribute(LanguageTag),
                LoanwordTypeAttribute = reader.GetAttribute(LoanwordTypeTag),
                LoanwordWaseiAttribute = reader.GetAttribute(LoanwordWaseiTag),
                GlossGenderAttribute = reader.GetAttribute(GlossGenderTag),
                GlossTypeAttribute = reader.GetAttribute(GlossTypeTag),
                Content = reader.ReadElementContentAsString()
            };

            return entryElementData;
        }

        public static async Task<EntryElementData> FromXmlReaderAsync(XmlReader reader)
        {
            var entryElementData = new EntryElementData
            {
                LanguageAttribute = reader.GetAttribute(LanguageTag),
                LoanwordTypeAttribute = reader.GetAttribute(LoanwordTypeTag),
                LoanwordWaseiAttribute = reader.GetAttribute(LoanwordWaseiTag),
                GlossGenderAttribute = reader.GetAttribute(GlossGenderTag),
                GlossTypeAttribute = reader.GetAttribute(GlossTypeTag),
                Content = await reader.ReadElementContentAsStringAsync()
            };

            return entryElementData;
        }

        public override string ToString() => Content;
    }
}
