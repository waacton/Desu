namespace Wacton.Desu.Romaji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Kanas;

    public class Transliterator
    {
        private readonly Dictionary<char, Kana> kanas = new Dictionary<char, Kana>();
        private readonly Dictionary<char, Youon> youons = new Dictionary<char, Youon>();
        private readonly Dictionary<char, Chouon> chouons = new Dictionary<char, Chouon>();
        private readonly Dictionary<char, Tokushuon> tokushuons = new Dictionary<char, Tokushuon>();
        private readonly Dictionary<char, Sokuon> sokuons = new Dictionary<char, Sokuon>();
        private readonly Dictionary<char, Kurikaeshi> kurikaeshis = new Dictionary<char, Kurikaeshi>();
        private readonly Dictionary<char, string> punctuations = new Dictionary<char, string>(); 

        public Transliterator()
        {
            this.Initialise();
        }

        private void Initialise()
        {
            foreach (var kana in Enumeration.GetAll<Kana>())
            {
                this.kanas.Add(kana.GetCharacter(Syllabary.Hiragana), kana);
                this.kanas.Add(kana.GetCharacter(Syllabary.Katakana), kana);
            }

            foreach (var youon in Enumeration.GetAll<Youon>())
            {
                this.youons.Add(youon.GetCharacter(Syllabary.Hiragana), youon);
                this.youons.Add(youon.GetCharacter(Syllabary.Katakana), youon);
            }

            foreach (var chouon in Enumeration.GetAll<Chouon>())
            {
                this.chouons.Add(chouon.GetCharacter(Syllabary.Hiragana), chouon);
                //this.chouons.Add(chouon.GetCharacter(KanaSyllabary.Katakana), chouon); - chouon is the same in both syllabaries
            }

            foreach (var tokushuon in Enumeration.GetAll<Tokushuon>())
            {
                this.tokushuons.Add(tokushuon.GetCharacter(Syllabary.Hiragana), tokushuon);
                this.tokushuons.Add(tokushuon.GetCharacter(Syllabary.Katakana), tokushuon);
            }

            foreach (var sokuon in Enumeration.GetAll<Sokuon>())
            {
                this.sokuons.Add(sokuon.GetCharacter(Syllabary.Hiragana), sokuon);
                this.sokuons.Add(sokuon.GetCharacter(Syllabary.Katakana), sokuon);
            }

            foreach (var kurikaeshi in Enumeration.GetAll<Kurikaeshi>())
            {
                this.kurikaeshis.Add(kurikaeshi.GetCharacter(Syllabary.Hiragana), kurikaeshi);
                this.kurikaeshis.Add(kurikaeshi.GetCharacter(Syllabary.Katakana), kurikaeshi);
            }

            this.punctuations.Add(' ', " ");
            this.punctuations.Add('　', " ");
            this.punctuations.Add('・', "-");
            this.punctuations.Add('、', ", ");
            this.punctuations.Add('〜', "~");
        }

        /// <summary>
        /// Returns the romaji transliteration of a string of kana characters.  Throws a TransliterationException if the string contains a non-kana character. 
        /// </summary>
        public string GetRomaji(string kanaCharacters)
        {
            if (string.IsNullOrEmpty(kanaCharacters))
            {
                return string.Empty;
            }

            var syllables = new List<string>();

            var i = 0;
            while (i < kanaCharacters.Length)
            {
                var punctuation = this.ObtainPunctuation(kanaCharacters, ref i);
                if (!string.IsNullOrEmpty(punctuation))
                {
                    syllables.Add(punctuation);
                    continue;
                }

                // if romaji for this syllable is null, bail out
                // no point in dealing with the other syllables if part of the word is "null"
                var syllable = this.ObtainNextSyllable(kanaCharacters, ref i);
                var romaji = syllable.GetRomaji();
                if (string.IsNullOrEmpty(romaji))
                {
                    var currentCharacter = GetCharacter(kanaCharacters, i);
                    if (currentCharacter.HasValue)
                    {
                        throw new TransliterationException($"\"{currentCharacter}\" is not a recognised kana character");
                    }

                    throw new TransliterationException("Unknown error occurred during transliteration");
                }

                syllables.Add(romaji);
            }

            return string.Concat(syllables).ToLower();
        }

        private string ObtainPunctuation(string kanaCharacters, ref int i)
        {
            return LookupTransliteration(this.punctuations, kanaCharacters, ref i);
        }

        private Syllable ObtainNextSyllable(string kanaCharacters, ref int i)
        {
            /*
             * not keen on using object initialiser here
             * makes it even less obvious that the order these are called are very important
             * also: currently no entries contain a kurikaeshi [except the actual kurikaeshi entry, which just confuses things], so ignoring
             */

#pragma warning disable IDE0017 // Simplify object initialization
            var syllable = new Syllable();
            syllable.Sokuon = LookupTransliteration(this.sokuons, kanaCharacters, ref i);
            syllable.Kana = LookupTransliteration(this.kanas, kanaCharacters, ref i);
            //syllable.Kurikaeshi = LookupTransliteration(kanaCharacters, ref i, this.kurikaeshis); 
            syllable.Youon = LookupTransliteration(this.youons, kanaCharacters, ref i);
            syllable.Tokushuon = LookupTransliteration(this.tokushuons, kanaCharacters, ref i);
            syllable.Chouon = LookupTransliteration(this.chouons, kanaCharacters, ref i);
            return syllable;
#pragma warning restore IDE0017 // Simplify object initialization
        }

        private static T LookupTransliteration<T>(IReadOnlyDictionary<char, T> dictionary, string kanaCharacters, ref int index)
        {
            var character = GetCharacter(kanaCharacters, index);
            if (!character.HasValue)
            {
                return default;
            }

            if (!dictionary.ContainsKey(character.Value))
            {
                return default;
            }

            index++;
            return dictionary[character.Value];
        }

        private static char? GetCharacter(string kanaCharacters, int index)
        {
            if (index >= kanaCharacters.Length)
            {
                return null;
            }

            return kanaCharacters[index];
        }
    }
}
