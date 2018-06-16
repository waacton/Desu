namespace Wacton.Desu.Resources
{
    using Wacton.Desu.Enums;
    using Wacton.Desu.Properties;

    public class Resource : Enumeration
    {
        public static readonly Resource JapaneseDictionary = new Resource("JapaneseDictionary", nameof(Resources.JMdict));
        public static readonly Resource KanjiDictionary = new Resource("KanjiDictionary", nameof(Resources.kanjidic2));
        public static readonly Resource NameDictionary = new Resource("NameDictionary", nameof(Resources.JMnedict));
        public static readonly Resource KanjiToRadicals1 = new Resource("KanjiToRadicals1", nameof(Resources.kradfile));
        public static readonly Resource KanjiToRadicals2 = new Resource("KanjiToRadicals2", nameof(Resources.kradfile2));
        public static readonly Resource RadicalToKanjis = new Resource("RadicalToKanjis", nameof(Resources.radkfilex));
        public static readonly Resource KanjiStrokes = new Resource("KanjiStrokes", nameof(Resources.KanjiVG));

        public string Name { get; }

        public Resource(string displayName, string resourceName)
            : base(displayName)
        {
            this.Name = resourceName;
        }
    }
}
