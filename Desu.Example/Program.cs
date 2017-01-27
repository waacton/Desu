namespace Wacton.Desu.Example
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new JapaneseDictionary();
            var entries = dictionary.GetEntries().ToList();

            var index = new Random().Next(0, entries.Count);
            var entry = entries[index];

            Debug.WriteLine(entry);

            var creationDate = dictionary.CreationDate;
            Debug.WriteLine($"JMdict created: {creationDate.ToShortDateString()}");
        }
    }
}
