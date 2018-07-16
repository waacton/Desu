﻿namespace Wacton.Desu.Japanese
{
    using System.Xml;

    public class EntryElementData
    {
        private static readonly string LanguageTag = "xml:lang";
        private static readonly string LoanwordTypeTag = "ls_type";
        private static readonly string LoanwordWaseiTag = "ls_wasei";
        private static readonly string GlossGenderTag = "g_gend";
        private static readonly string GlossTypeTag = "g_type";

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

        public override string ToString()
        {
            return this.Content;
        }
    }
}
