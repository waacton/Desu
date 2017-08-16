namespace Wacton.Desu.Resources
{
    using System;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    internal static class EmbeddedResources
    {
        internal static T ReadStream<T>(Resource resource, Func<XmlReader, T> readerFunction)
        {
            using (var stream = GetEmbeddedResouceStream(resource.Name))
            using (var streamReader = new StreamReader(stream))
            {
                var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
                using (var xmlReader = XmlReader.Create(streamReader, settings))
                {
                    var readResult = readerFunction(xmlReader);
                    stream.Close();
                    return readResult;
                }
            }
        }

        internal static T ReadStream<T>(Resource resource, Func<StreamReader, T> readerFunction)
        {
            using (var stream = GetEmbeddedResouceStream(resource.Name))
            using (var streamReader = new StreamReader(stream))
            {
                var readResult = readerFunction(streamReader);
                stream.Close();
                return readResult;
            }
        }

        private static Stream GetEmbeddedResouceStream(string resourceNameEnding)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(resource => resource.Replace(".zip", string.Empty).EndsWith(resourceNameEnding));
            var resourceStream = assembly.GetManifestResourceStream(resourceName);
            if (!resourceName.EndsWith(".zip"))
            {
                return resourceStream;
            }

            var zipArchive = new ZipArchive(resourceStream, ZipArchiveMode.Read);
            return zipArchive.Entries.Single().Open();
        }
    }
}
