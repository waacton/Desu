namespace Wacton.Desu.Resources
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    using Ionic.Zip;

    internal static class EmbeddedResources
    {
        internal static Stream OpenJapaneseDictionary()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.JMdict));
        }

        internal static Stream OpenKanjiDictionary()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.kanjidic2));
        }

        internal static Stream OpenKanjiToRadicals1()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.kradfile));
        }

        internal static Stream OpenKanjiToRadicals2()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.kradfile2));
        }

        internal static Stream OpenRadicalToKanjis()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.radkfilex));
        }

        internal static Stream OpenKanjiStrokes()
        {
            return GetEmbeddedResouceStream(nameof(Properties.Resources.KanjiVG));
        }

        internal static T ReadXmlStream<T>(Stream stream, Func<XmlReader, T> readerFunction)
        {
            using (var streamReader = new StreamReader(stream))
            {
                var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
                using (var reader = XmlReader.Create(streamReader, settings))
                {
                    return readerFunction(reader);
                }
            }
        }

        private static Stream GetEmbeddedResouceStream(string resourceNameEnding)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(resource => resource.Replace(".zip", string.Empty).EndsWith(resourceNameEnding));
            var resourceStream = assembly.GetManifestResourceStream(resourceName);
            return resourceName.EndsWith(".zip") ? ZipFile.Read(resourceStream).Single().OpenReader() : resourceStream;
        }

       
    }
}
