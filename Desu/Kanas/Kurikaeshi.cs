namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class Kurikaeshi : Enumeration
    {
        public static readonly Kurikaeshi SeionRepetition = new Kurikaeshi("SeionRepetition", 'ゝ', 'ヽ');
        public static readonly Kurikaeshi DakutenRepetition = new Kurikaeshi("DakutenRepetition", 'ゞ', 'ヾ');

        private readonly Dictionary<Syllabary, char> dict;

        public Kurikaeshi(string friendlyString, char hiraganaTokushuon, char katakanaTokushuon)
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
