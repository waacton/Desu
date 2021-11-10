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

            var resultDictionary = new Dictionary<string, string> {{string.Empty, string.Join(Environment.NewLine, Header)}};

            foreach (var radical in radicalsFromFile)
            {
                var stringBuilder = new StringBuilder();

                var (character, strokes, code) = RadicalsInFile.OrderedRadicals.Single(x => x.character == radical);
                stringBuilder.AppendLine($"$ {character} {strokes}{(string.IsNullOrWhiteSpace(code) ? string.Empty : " " + code)}");

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
            File.WriteAllText("radkfilex2", string.Join(string.Empty, outputTexts));
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

        private static List<string> Header => new List<string>
        {
            "#",
            "#                           R A D K F I L E X 2 . 0",
            "#",
            "#      Copyright 2021 William Acton, made available under the",
            "#      Creative Commons Attribution-ShareAlike 4.0 International License",
            "#      https://creativecommons.org/licenses/by-sa/4.0/",
            "#",
            "# The radkfilex2.0 is a regeneration of radkfilex based on an analysis",
            "# of the kradfile and kradfile2 source files.",
            "#",
            "# This version of radkfilex includes:",
            "# - removal of duplicate kanji characters associated with a single radical",
            "# - use of unicode numbers instead of JIS codes or image references",
            "#   for glyphs that cannot be depicted in the original encoding of the files",
            "#",
            "# See below for more information about the original source files",
            "# (kradfile, kradfile2, radkfile, radkfile2, and radkfilex)",
            "#",
            "#",
            "#                           R A D K F I L E X",
            "#",
            "# The Radkfilex file (Radkfile extended) is built from a combination",
            "# of the kradfile and kradfile2 source files. See below for more information",
            "# about these.",
            "#",
            "#",
            "#                           R A D K F I L E",
            "#",
            "#	Copyright 2001/2007 Michael Raine, James Breen and the Electronic",
            "#       Dictionary Research & Development Group",
            "#	See: http://www.edrdg.org/edrdg/licence.html",
            "#       for permissions for use and redistribution.",
            "# ",
            "# This is the data file that drives the multi-radical lookup method in XJDIC,",
            "# WWWJDIC and possibly other dictionary and related software.",
            "# ",
            "# The file is based on work done in 1994/1995 by Michael Raine in which he",
            "# analyzed all the JIS1/2 kanji and identified the constituent radicals and ",
            "# other common elements, with the intention of facilitating the selection of",
            "# kanji within a dictionary program by identifying multiple elements.",
            "# The file was revised by Jim Breen in September 1995. Further revisions were",
            "# done in 1998/9 at the suggestion of Wolfgang Conrath, then a revision was",
            "# carried out in 2001 using suggestions from Yutaka Ohno based on a similar",
            "# decomposition made by Kobayashi. Further amendments were made in July",
            "# 2001 after suggestions from Hendrik.",
            "#",
            "# The file has been modified on numerous occasions. See the header on the",
            "# \"kradfile\" for some details of these.",
            "# ",
            "# The format of the file is as follows:",
            "# ",
            "# (a) all lines starting with a # are comments",
            "# (b) all lines starting with a $ identify a kanji element, followed by its",
            "# stroke-count and optionally either the JIS X 0212 code of the kanji ",
            "# whose glyph better depicts the element in question or the name of an image",
            "# file (used by the WWWJDIC server).",
            "# (c) all other lines with kanji in them are associated with the previously",
            "# identified element.",
            "# ",
            "# The file can, of course, be modified by users to suit their preferences.",
            "# Note that this file has been automatically compiled from another file,",
            "# \"kradfile\", in which each of the JIS1/2 kanji is listed, along with its",
            "# elements.",
            "# ",
            "# Jim Breen, Tokyo, January 2001",
            "#            Melbourne, July 2001",
            "#            Melbourne, Dec  2004",
            "#            Melbourne, Oct  2013",
            "#",
            "#",
            "#                           R A D K F I L E - 2",
            "#",
            "#       Copyright 2007 James Rose and the KanjiCafe.com.",
            "#",
            "#   Special GRANT OF LICENSE is hereby given to James Breen and the",
            "#   Electronic Dictionary Research & Development Group ",
            "#   such that said licensees may maintain, modify, use,",
            "#   and redistribute this file.  Derivatives should maintain this notice.",
            "#   All other rights reserved.",
            "#",
            "# Radkfile - 2 is built as required from the Kradfile -2 source file, and is",
            "# in the same format as the original JIS X 0208 Radkfile.",
            "#",
            "# Kradfile - 2 was created by James Rose by means of analysis of",
            "# all 5,801 JIS X 0212 Kanji and identification of the constituent",
            "# radicals and other common elements, with the goal of extending the",
            "# capability of current kanji selection by-multi-radical tools in this range.",
            "# Care has been exercised to maintain the same format as the original",
            "# kradfile by Michael Raine and Jim Breen to aid in integration with",
            "# existing electronic dictionary programs.",
            "#",
            "# Two fonts were used in decomposition so as to include as many glyphs as",
            "# possible.  One apparently based on the JIS X 0212 standard itself, and",
            "# one based on Unicode.  Each JIS X 0212 kanji is represented by 3 bytes",
            "# in EUC-JP encoding, as opposed to the two bytes used in the JIS X 0208",
            "# range, so adjust your software accordingly if necessary.",
            "#",
            "# The useable portion of the file consists of 5,801 lines; one for each of the",
            "# JIS X 0212 kanji. Each line is a follows:",
            "# - the kanji itself,",
            "# - a space followed by a colon (:) followed by a space,",
            "# - one or more radicals/elements which can be seen in the kanji. These",
            "#   are drawn from JIS X 0208-1997. Where the element alone is not in",
            "#   JIS X 0208, a kanji which contains the element is used instead.",
            "#",
            "# The decomposition is based on what can be seen in typical kanji",
            "# glyphs. Elements themselves can be further subdivided.",
            "#",
            "# You can contact Jim Rose at Jim(at)Kanjicafe.com.",
            "#",
            "# Jim Rose, Christiansted, United States Virgin Islands",
            "# September 2007",
            "###########################################################" + Environment.NewLine,
        };
    }
}