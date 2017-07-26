namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Tokushuon : Enumeration
    {
        public static readonly Tokushuon A = new Tokushuon("A", 'ぁ', 'ァ');
        public static readonly Tokushuon I = new Tokushuon("I", 'ぃ', 'ィ');
        public static readonly Tokushuon U = new Tokushuon("U", 'ぅ', 'ゥ');
        public static readonly Tokushuon E = new Tokushuon("E", 'ぇ', 'ェ');
        public static readonly Tokushuon O = new Tokushuon("O", 'ぉ', 'ォ');
        public static readonly Tokushuon Wa = new Tokushuon("Wa", 'ゎ', 'ヮ');

        private readonly string romaji;
        private readonly Dictionary<Syllabary, char> dict;

        public Tokushuon(string romaji, char hiraganaTokushuon, char katakanaTokushuon)
            : base(romaji)
        {
            this.romaji = romaji;
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

        public string GetRomaji()
        {
            return this.romaji;
        }
    }
}
