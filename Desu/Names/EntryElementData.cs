namespace Wacton.Desu.Names
{
    using System.Xml;

    public class EntryElementData
    {
        private static readonly string LanguageTag = "xml:lang";

        public string Content { get; private set; }

        public string LanguageAttribute { get; private set; }

        public static EntryElementData FromXmlReader(XmlReader reader)
        {
            var entryElementData = new EntryElementData
            {
                LanguageAttribute = reader.GetAttribute(LanguageTag),
                Content = reader.ReadElementContentAsString()
            };

            return entryElementData;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
