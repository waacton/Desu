namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Chouon : Enumeration
    {
        public static readonly Chouon VowelExtension = new Chouon("VowelExtension", 'ー', 'ー');

        private readonly Dictionary<Syllabary, char> dict;

        public Chouon(string friendlyString, char hiraganaTokushuon, char katakanaTokushuon)
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
