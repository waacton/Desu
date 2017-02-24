namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    using Wacton.Desu.Resources;
    using Wacton.Tovarisch.Enum;

    public class KanjiDictionary : IKanjiDictionary
    {

        private static readonly string CharacterElement = "character";

        private static readonly string CodepointTypeAttribute = "cp_type";
        private static readonly string RadicalTypeAttribute = "rad_type";
        private static readonly string VariantTypeAttribute = "var_type";
        private static readonly string ReferenceTypeAttribute = "dr_type";
        private static readonly string ReferenceVolumeAttribute = "m_vol";
        private static readonly string ReferencePageAttribute = "m_page";
        private static readonly string QueryCodeTypeAttribute = "qc_type";
        private static readonly string SkipMisclassificationAttribute = "skip_misclass";
        private static readonly string ReadingTypeAttribute = "r_type";
        private static readonly string LanguageAttribute = "m_lang";

        private static readonly string CreationDateElement = "date_of_creation";

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                if (this.creationDate == DateTime.MinValue)
                {
                    this.creationDate = ParseCreationDate();
                }

                return this.creationDate;
            }
        }

        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        public IEnumerable<IKanjiEntry> GetEntries()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseDictionary);
        }

        private static IEnumerable<IKanjiEntry> ParseDictionary(XmlReader reader)
        {
            var entries = new List<IKanjiEntry>();
            var characterElements = Enumeration.GetAll<CharacterElement>().ToDictionary(element => element.Code, element => element);

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != CharacterElement)
                {
                    continue;
                }

                // now within an entry, can now create data entry
                // keep reading until the end entry tag is reached
                var dictionaryEntry = new KanjiEntry();
                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        var elementCode = reader.Name;
                        if (!characterElements.ContainsKey(elementCode))
                        {
                            continue;
                        }

                        var characterElement = characterElements[elementCode];
                        var characterElementData = ReadCharacterElementData(reader);
                        characterElement.AddDataToEntry(dictionaryEntry, characterElementData);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(CharacterElement);
                    }
                }

                entries.Add(dictionaryEntry);
            }

            return entries;
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

        private static DateTime ParseCreationDate()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseCreationDate);
        }

        private static DateTime ParseCreationDate(XmlReader reader)
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
