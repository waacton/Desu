namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Youon : Enumeration
    {
        public static readonly Youon Ya = new Youon("Ya", 'ゃ', 'ャ');
        public static readonly Youon Yu = new Youon("Yu", 'ゅ', 'ュ');
        public static readonly Youon Yo = new Youon("Yo", 'ょ', 'ョ');

        private readonly string romaji;
        private readonly Dictionary<Syllabary, char> dict; 

        public Youon(string romaji, char hiraganaYouon, char katakanaYouon)
            : base(romaji)
        {
            this.romaji = romaji;
            this.dict = new Dictionary<Syllabary, char>
                        {
                            { Syllabary.Hiragana, hiraganaYouon },
                            { Syllabary.Katakana, katakanaYouon }
                        };
        }

        public char GetCharacter(Syllabary kanaSyllabary)
        {
            return this.dict[kanaSyllabary];
        }

        public string GetRomaji()
        {
            return this.romaji;
        }
    }
}
