namespace Wacton.Desu.Names
{
    using System.Threading.Tasks;
    using System.Xml;

    internal class EntryElementData
    {
        public string Content { get; private set; }

        public static EntryElementData FromXmlReader(XmlReader reader)
        {
            var entryElementData = new EntryElementData
            {
                Content = reader.ReadElementContentAsString()
            };

            return entryElementData;
        }

        public static async Task<EntryElementData> FromXmlReaderAsync(XmlReader reader)
        {
            var entryElementData = new EntryElementData
            {
                Content = await reader.ReadElementContentAsStringAsync()
            };

            return entryElementData;
        }

        public override string ToString() => this.Content;
    }
}
