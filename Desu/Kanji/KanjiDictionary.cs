namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;

    using Wacton.Desu.Resources;
    using Wacton.Tovarisch.Enum;

    public class KanjiDictionary : IKanjiDictionary
    {
        private const string CharacterElement = "character";
        private static readonly Dictionary<string, CharacterElement> CharacterElements =
            Enumeration.GetAll<CharacterElement>().ToDictionary(element => element.Code, element => element);

        private const string CodepointTypeAttribute = "cp_type";
        private const string RadicalTypeAttribute = "rad_type";
        private const string VariantTypeAttribute = "var_type";
        private const string ReferenceTypeAttribute = "dr_type";
        private const string ReferenceVolumeAttribute = "m_vol";
        private const string ReferencePageAttribute = "m_page";
        private const string QueryCodeTypeAttribute = "qc_type";
        private const string SkipMisclassificationAttribute = "skip_misclass";
        private const string ReadingTypeAttribute = "r_type";
        private const string LanguageAttribute = "m_lang";

        private const string CreationDateElement = "date_of_creation";

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file (DateTime.MinValue if not found)
        /// </summary>
        public DateTime CreationDate => this.GetCreationDate();
        private DateTime GetCreationDate()
        {
            return this.ParseCreationDate(EmbeddedResources.OpenKanjiDictionary);
        }

        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        public IEnumerable<IKanjiDictionaryEntry> GetEntries()
        {
            var xmlStream = EmbeddedResources.OpenKanjiDictionary();
            return EmbeddedResources.ReadXmlStream(xmlStream, ParseDictionary);
        }

        private static IEnumerable<IKanjiDictionaryEntry> ParseDictionary(XmlReader reader)
        {
            var dictionaryEntries = new List<IKanjiDictionaryEntry>();

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != CharacterElement)
                {
                    continue;
                }

                // now within an entry, can now create data entry
                // keep reading until the end entry tag is reached
                var dictionaryEntry = new KanjiDictionaryEntry();
                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        var elementCode = reader.Name;
                        if (!CharacterElements.ContainsKey(elementCode))
                        {
                            continue;
                        }

                        var characterElement = CharacterElements[elementCode];
                        var characterElementData = ReadCharacterElementData(reader);
                        characterElement.AddDataToEntry(dictionaryEntry, characterElementData);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(CharacterElement);
                    }
                }

                dictionaryEntries.Add(dictionaryEntry);
            }

            return dictionaryEntries;
        }

        private static CharacterElementData ReadCharacterElementData(XmlReader reader)
        {
            var codepointTypeAttribute = reader.GetAttribute(CodepointTypeAttribute);
            var radicalTypeAttribute = reader.GetAttribute(RadicalTypeAttribute);
            var variantTypeAttribute = reader.GetAttribute(VariantTypeAttribute);
            var referenceTypeAttribute = reader.GetAttribute(ReferenceTypeAttribute);
            var referenceVolumeAttribute = reader.GetAttribute(ReferenceVolumeAttribute);
            var referencePageAttribute = reader.GetAttribute(ReferencePageAttribute);
            var queryCodeTypeAttribute = reader.GetAttribute(QueryCodeTypeAttribute);
            var skipMisclassificationAttribute = reader.GetAttribute(SkipMisclassificationAttribute);
            var readingTypeAttribute = reader.GetAttribute(ReadingTypeAttribute);
            var languageAttribute = reader.GetAttribute(LanguageAttribute);

            var content = reader.ReadElementContentAsString();

            return new CharacterElementData(
                content,
                codepointTypeAttribute, radicalTypeAttribute,
                variantTypeAttribute, referenceTypeAttribute,
                referenceVolumeAttribute, referencePageAttribute,
                queryCodeTypeAttribute, skipMisclassificationAttribute,
                readingTypeAttribute, languageAttribute);
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
                if (reader.NodeType != XmlNodeType.Element || reader.Name != CreationDateElement)
                {
                    continue;
                }

                var content = reader.ReadElementContentAsString();
                return DateTime.Parse(content);
            }

            return DateTime.MinValue;
        }
    }
}
