namespace Wacton.Desu.Japanese
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    using Wacton.Desu.Resources;
    using Wacton.Tovarisch.Enum;

    public class JapaneseDictionary : IJapaneseDictionary
    {
        private const string EntryElement = "entry";
        private static readonly Dictionary<string, EntryElement> EntryElements =
            Enumeration.GetAll<EntryElement>().ToDictionary(element => element.Code, element => element);

        private const string LanguageAttribute = "xml:lang";
        private const string LoanwordTypeAttribute = "ls_type";
        private const string LoanwordWaseiAttribute = "ls_wasei";
        private const string GlossGenderAttribute = "g_gend";

        private const string CreationDatePrefix = "JMdict created: ";

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file
        /// </summary>
        public DateTime CreationDate => this.GetCreationDate();
        private DateTime GetCreationDate()
        {
            return this.ParseCreationDate(EmbeddedResources.OpenJapaneseDictionary);
        }

        /// <summary>
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        public IEnumerable<IJapaneseDictionaryEntry> GetEntries()
        {
            var xmlStream = EmbeddedResources.OpenJapaneseDictionary();
            return EmbeddedResources.ReadXmlStream(xmlStream, ParseDictionary);
        }

        private static IEnumerable<IJapaneseDictionaryEntry> ParseDictionary(XmlReader reader)
        {
            var dictionaryEntries = new List<IJapaneseDictionaryEntry>();

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != EntryElement)
                {
                    continue;
                }

                // now within an entry, can now create data entry
                // keep reading until the end entry tag is reached
                var dictionaryEntry = new JapaneseDictionaryEntry();
                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        var elementCode = reader.Name;
                        if (!EntryElements.ContainsKey(elementCode))
                        {
                            continue;
                        }

                        var entryElement = EntryElements[elementCode];
                        if (!entryElement.ExpectsContent)
                        {
                            entryElement.AddDataToEntry(dictionaryEntry, null);
                            continue;
                        }

                        var entryElementData = ReadEntryElementData(reader);
                        entryElement.AddDataToEntry(dictionaryEntry, entryElementData);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(EntryElement);
                    }
                }

                dictionaryEntries.Add(dictionaryEntry);
            }

            return dictionaryEntries;
        }

        private static EntryElementData ReadEntryElementData(XmlReader reader)
        {
            var languageAttribute = reader.GetAttribute(LanguageAttribute);
            var loanwordTypeAttribute = reader.GetAttribute(LoanwordTypeAttribute);
            var loanwordWaseiAttribute = reader.GetAttribute(LoanwordWaseiAttribute);
            var glossGenderAttribute = reader.GetAttribute(GlossGenderAttribute);

            var content = reader.ReadElementContentAsString();

            return new EntryElementData(
                content,
                languageAttribute, glossGenderAttribute,
                loanwordTypeAttribute, loanwordWaseiAttribute);
        }

        private DateTime ParseCreationDate(Func<Stream> openStreamFunction)
        {
            if (this.creationDate != DateTime.MinValue)
            {
                return this.creationDate;
            }

            using (var stream = openStreamFunction())
            {
                var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
                using (var reader = XmlReader.Create(stream, settings))
                {
                    this.creationDate = this.ParseCreationDate(reader);
                }
            }

            return this.creationDate;
        }

        private DateTime ParseCreationDate(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType != XmlNodeType.Comment)
                {
                    continue;
                }

                if (!reader.Value.Contains(CreationDatePrefix))
                {
                    continue;
                }

                var commentSplit = reader.Value.Split(new[] { CreationDatePrefix }, StringSplitOptions.RemoveEmptyEntries);
                return DateTime.Parse(commentSplit[1]);
            }

            return DateTime.MinValue;
        }
    }
}
