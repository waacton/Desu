namespace RadkfileGenerator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Wacton.Desu.Radicals;

    class Program
    {
        static void Main(string[] args)
        {
            var kanjiToRadicals = RadicalLookup.ParseKanjiToRadicals();

            var radicalsFromFile = RadicalsInFile.OrderedRadicals.Select(x => x.character).ToList();
            var radicalsFromKanji = kanjiToRadicals.Values.SelectMany(x => x).Distinct().ToList();

            CheckListsMatch(radicalsFromKanji, radicalsFromFile);

            var resultDictionary = new Dictionary<string, string>();
            
            foreach (var radical in radicalsFromFile)
            {
                var stringBuilder = new StringBuilder();

                var (character, strokes, alt) = RadicalsInFile.OrderedRadicals.Single(x => x.character == radical);
                stringBuilder.AppendLine($"$ {character} {strokes}{(string.IsNullOrWhiteSpace(alt) ? string.Empty : " " + alt)}");

                var kanjisContainingRadical = kanjiToRadicals.Where(x => x.Value.Contains(radical)).Select(x => x.Key).ToList();
                while (kanjisContainingRadical.Any())
                {
                    var line = kanjisContainingRadical.GetRange(0, Math.Min(36, kanjisContainingRadical.Count));
                    kanjisContainingRadical.RemoveRange(0, Math.Min(36, kanjisContainingRadical.Count));
                    stringBuilder.AppendLine(string.Join(string.Empty, line));
                }

                var result = stringBuilder.ToString();
                resultDictionary.Add(radical, result);
            }

            var outputTexts = resultDictionary.Values.ToList();
            File.WriteAllText("radkfilex-updated", string.Join(string.Empty, outputTexts));
        }
        
        static void CheckListsMatch(List<string> list1, List<string> list2)
        {
            var list1Ordered = new List<string>(list1).OrderBy(x => x);
            var list2Ordered = new List<string>(list2).OrderBy(x => x);
            if (!list1Ordered.SequenceEqual(list2Ordered))
            {
                throw new InvalidOperationException();
            }
        }
    }
}