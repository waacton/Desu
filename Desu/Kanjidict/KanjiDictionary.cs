namespace Wacton.Desu.Kanjidict
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    using Ionic.Zip;

    using Wacton.Tovarisch.Enum;

    public class KanjiDictionary : IKanjiDictionary
    {
        private const string DictionaryName = "kanjidic2";
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

        private const string CreationDatePrefix = "JMdict created:";

        public readonly string DictionaryFilePath;
        public bool IsOverriding => this.DictionaryFilePath != null;

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file (DateTime.MinValue if not found)
        /// </summary>
        public DateTime CreationDate => this.GetCreationDate();

        /// <summary> 
        /// Provides Japanese dictionary entries from the default embedded dictionary file 
        /// </summary>
        public KanjiDictionary()
        {
            this.DictionaryFilePath = null;
        }

        /// <summary> 
        /// Provides Japanese dictionary entries from the custom specified dictionary file.
        /// File assumed to follow JMdict 1.08 formatting (http://www.edrdg.org/jmdict/edict_doc.html#IREF02)
        /// </summary>
        public KanjiDictionary(string dictionaryFilepath)
        {
            this.DictionaryFilePath = Path.GetFullPath(dictionaryFilepath);
        }

        /// <summary>
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        public IEnumerable<IKanjiDictionaryEntry> GetEntries()
        {
            return this.IsOverriding
                ? ParseDictionary(() => File.OpenRead(this.DictionaryFilePath))
                : ParseDictionary(GetEmbeddedResouceStream);
        }

        private DateTime GetCreationDate()
        {
            return this.IsOverriding
                ? this.ParseCreationDate(() => File.OpenRead(this.DictionaryFilePath))
                : this.ParseCreationDate(GetEmbeddedResouceStream);
        }

        private static Stream GetEmbeddedResouceStream()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(resource => resource.Contains(DictionaryName));
            var resourceStream = assembly.GetManifestResourceStream(resourceName);
            return ZipFile.Read(resourceStream).Single().OpenReader();
        }

        private static IEnumerable<IKanjiDictionaryEntry> ParseDictionary(Func<Stream> openStreamFunction)
        {
            using (var stream = openStreamFunction())
            {
                var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
                using (var reader = XmlReader.Create(stream, settings))
                {
                    return ParseDictionary(reader);
                }
            }
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
                        CharacterElementData characterElementData = null;
                        if (characterElement.ExpectsContent)
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
                            characterElementData = new CharacterElementData(
                                content, 
                                codepointTypeAttribute, radicalTypeAttribute, 
                                variantTypeAttribute, referenceTypeAttribute, 
                                referenceVolumeAttribute, referencePageAttribute, 
                                queryCodeTypeAttribute, skipMisclassificationAttribute, 
                                readingTypeAttribute, languageAttribute);
                        }

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
                if (reader.NodeType != XmlNodeType.Element || reader.Name != "date_of_creation")
                {
                    continue;
                }

                var content = reader.ReadElementContentAsString();
                return DateTime.Parse(content);
            }

            return DateTime.MinValue;
        }

        public override string ToString()
        {
            var dictionaryLocation = this.IsOverriding ? this.DictionaryFilePath : "embedded resource";
            return $"Dictionary file @ {dictionaryLocation}";
        }
    }
}
