namespace Wacton.Desu.Romaji
{
    using System;

    using Wacton.Desu.Kanas;

    internal class Syllable
    {
        public Kana Kana;
        public Kurikaeshi Kurikaeshi;
        public Chouon Chouon;
        public Sokuon Sokuon;
        public Youon Youon;
        public Tokushuon Tokushuon;

        private bool HasKana => Kana != null;
        private bool HasKurikaeshi => Kurikaeshi != null;
        private bool HasChouon => Chouon != null;
        private bool HasSokuon => Sokuon != null;
        private bool HasYouon => Youon != null;
        private bool HasTokushuon => Tokushuon != null;

        public string GetKanaCharacters(Syllabary syllabary)
        {
            var sokuon = HasSokuon ? Sokuon.GetCharacter(syllabary).ToString() : string.Empty;
            var kana = HasKana ? Kana.GetCharacter(syllabary).ToString() : string.Empty;
            var kurikaeshi = HasKurikaeshi ? Kurikaeshi.GetCharacter(syllabary).ToString() : string.Empty;
            var youon = HasYouon ? Youon.GetCharacter(syllabary).ToString() : string.Empty;
            var tokushuon = HasTokushuon ? Tokushuon.GetCharacter(syllabary).ToString() : string.Empty;
            var chouon = HasChouon ? Chouon.GetCharacter(syllabary).ToString() : string.Empty;

            return $"{sokuon}{kana}{kurikaeshi}{youon}{tokushuon}{chouon}";
        }

        public string GetRomaji()
        {
            string romaji;
            if (!HasKana)
            {
                if (HasSokuon)
                {
                    romaji = "'";
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (HasYouon && HasTokushuon)
                {
                    throw new InvalidOperationException("Unable to represent in romaji a syllable that contains youon and tokushuon");
                }

                if (!HasYouon && !HasTokushuon)
                {
                    romaji = Kana.GetRomaji(HasChouon, HasSokuon);
                }
                else if (HasYouon)
                {
                    romaji = Kana.GetRomaji(Youon, HasChouon, HasSokuon);
                }
                else
                {
                    romaji = Kana.GetRomaji(Tokushuon, HasChouon, HasSokuon);
                }
            }

            return romaji;
        }

        public override string ToString()
        {
            var hiraganaCharacters = GetKanaCharacters(Syllabary.Hiragana);
            var katakanaCharacters = GetKanaCharacters(Syllabary.Katakana);
            var romaji = GetRomaji();
            if (string.IsNullOrEmpty(romaji))
            {
                romaji = "no romaji available";
            }

            return string.IsNullOrEmpty(hiraganaCharacters) ? "empty syllable" : $"{hiraganaCharacters} / {katakanaCharacters} ({romaji})";
        }
    }
}
