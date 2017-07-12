namespace Wacton.Desu.Names
{
    using System.Xml;

    public class EntryElementData
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

        public override string ToString()
        {
            return this.Content;
        }
    }
}
