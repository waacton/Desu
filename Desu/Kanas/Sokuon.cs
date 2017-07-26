namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Sokuon : Enumeration
    {
        public static readonly Sokuon ConsonantGemination = new Sokuon("ConsonantGemination", 'っ', 'ッ');

        private readonly Dictionary<Syllabary, char> dict;

        public Sokuon(string friendlyString, char hiraganaTokushuon, char katakanaTokushuon)
            : base(friendlyString)
        {
            this.dict = new Dictionary<Syllabary, char>
                        {
                            { Syllabary.Hiragana, hiraganaTokushuon },
                            { Syllabary.Katakana, katakanaTokushuon }
                        };
        }

        public char GetCharacter(Syllabary kanaSyllabary)
        {
            return this.dict[kanaSyllabary];
        }
    }
}
