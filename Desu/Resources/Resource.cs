namespace Wacton.Desu.Resources
{
    using Wacton.Desu.Enums;

    public class Resource : Enumeration
    {
        public static readonly Resource JapaneseDictionary = new Resource("JapaneseDictionary", nameof(Properties.Resources.JMdict));
        public static readonly Resource KanjiDictionary = new Resource("KanjiDictionary", nameof(Properties.Resources.kanjidic2));
        public static readonly Resource NameDictionary = new Resource("NameDictionary", nameof(Properties.Resources.JMnedict));
        public static readonly Resource KanjiToRadicals1 = new Resource("KanjiToRadicals1", nameof(Properties.Resources.kradfile));
        public static readonly Resource KanjiToRadicals2 = new Resource("KanjiToRadicals2", nameof(Properties.Resources.kradfile2));
        public static readonly Resource RadicalToKanjis = new Resource("RadicalToKanjis", nameof(Properties.Resources.radkfilex));
        public static readonly Resource KanjiStrokes = new Resource("KanjiStrokes", nameof(Properties.Resources.KanjiVG));

        public string Name { get; }

        public Resource(string displayName, string resourceName)
            : base(displayName)
        {
            this.Name = resourceName;
        }
    }
}
