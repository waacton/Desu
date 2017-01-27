namespace Wacton.Desu
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    using Ionic.Zip;

    using Wacton.Tovarisch.Enum;

    public class JapaneseDictionary : IJapaneseDictionary
    {
        private const string DictionaryName = "JMdict";
        private const string EntryElement = "entry";
        private static readonly Dictionary<string, EntryElement> EntryElements =
            Enumeration.GetAll<EntryElement>().ToDictionary(element => element.Code, element => element);

        private const string LanguageAttribute = "xml:lang";
        private const string LoanwordTypeAttribute = "ls_type";
        private const string LoanwordWaseiAttribute = "ls_wasei";
        private const string GlossGenderAttribute = "g_gend";

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
        public JapaneseDictionary()
        {
            this.DictionaryFilePath = null;
        }

        /// <summary> 
        /// Provides Japanese dictionary entries from the custom specified dictionary file.
        /// File assumed to follow JMdict 1.08 formatting (http://www.edrdg.org/jmdict/edict_doc.html#IREF02)
        /// </summary>
        public JapaneseDictionary(string dictionaryFilepath)
        {
            this.DictionaryFilePath = Path.GetFullPath(dictionaryFilepath);
        }

        /// <summary>
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        public IEnumerable<IJapaneseDictionaryEntry> GetEntries()
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

        private static IEnumerable<IJapaneseDictionaryEntry> ParseDictionary(Func<Stream> openStreamFunction)
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
                        EntryElementData entryElementData = null;
                        if (entryElement.ExpectsContent)
                        {
                            var languageAttribute = reader.GetAttribute(LanguageAttribute);
                            var loanwordTypeAttribute = reader.GetAttribute(LoanwordTypeAttribute);
                            var loanwordWaseiAttribute = reader.GetAttribute(LoanwordWaseiAttribute);
                            var glossGenderAttribute = reader.GetAttribute(GlossGenderAttribute);
                            var content = reader.ReadElementContentAsString();
                            entryElementData = new EntryElementData(content, languageAttribute, glossGenderAttribute, loanwordTypeAttribute, loanwordWaseiAttribute);
                        }

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

                if (!reader.Value.Contains("JMdict created: "))
                {
                    continue;
                }

                var commentSplit = reader.Value.Split(new[] { CreationDatePrefix }, StringSplitOptions.RemoveEmptyEntries);
                return DateTime.Parse(commentSplit[1]);
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
