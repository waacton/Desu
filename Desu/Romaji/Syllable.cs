namespace Wacton.Desu.Romaji
{
    using System;

    using Wacton.Desu.Kanas;

    public class Syllable
    {
        public Kana Kana;
        public Kurikaeshi Kurikaeshi;
        public Chouon Chouon;
        public Sokuon Sokuon;
        public Youon Youon;
        public Tokushuon Tokushuon;

        private bool HasKana => this.Kana != null;
        private bool HasKurikaeshi => this.Kurikaeshi != null;
        private bool HasChouon => this.Chouon != null;
        private bool HasSokuon => this.Sokuon != null;
        private bool HasYouon => this.Youon != null;
        private bool HasTokushuon => this.Tokushuon != null;

        public string GetKanaCharacters(Syllabary syllabary)
        {
            var sokuon = this.HasSokuon ? this.Sokuon.GetCharacter(syllabary).ToString() : string.Empty;
            var kana = this.HasKana ? this.Kana.GetCharacter(syllabary).ToString() : string.Empty;
            var kurikaeshi = this.HasKurikaeshi ? this.Kurikaeshi.GetCharacter(syllabary).ToString() : string.Empty;
            var youon = this.HasYouon ? this.Youon.GetCharacter(syllabary).ToString() : string.Empty;
            var tokushon = this.HasTokushuon ? this.Tokushuon.GetCharacter(syllabary).ToString() : string.Empty;
            var chouon = this.HasChouon ? this.Chouon.GetCharacter(syllabary).ToString() : string.Empty;

            return $"{sokuon}{kana}{kurikaeshi}{youon}{tokushon}{chouon}";
        }

        public string GetRomaji()
        {
            string romaji;
            if (!this.HasKana)
            {
                if (this.HasSokuon)
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
                if (this.HasYouon && this.HasTokushuon)
                {
                    throw new InvalidOperationException("Unable to represent in romaji a syllable that contains youon and tokushuon");
                }

                if (!this.HasYouon && !this.HasTokushuon)
                {
                    romaji = this.Kana.GetRomaji(this.HasChouon, this.HasSokuon);
                }
                else if (this.HasYouon)
                {
                    romaji = this.Kana.GetRomaji(this.Youon, this.HasChouon, this.HasSokuon);
                }
                else
                {
                    romaji = this.Kana.GetRomaji(this.Tokushuon, this.HasChouon, this.HasSokuon);
                }
            }

            return romaji;
        }

        public override string ToString()
        {
            var hiraganaCharacters = this.GetKanaCharacters(Syllabary.Hiragana);
            var katakanaCharacters = this.GetKanaCharacters(Syllabary.Katakana);
            var romaji = this.GetRomaji();
            if (string.IsNullOrEmpty(romaji))
            {
                romaji = "no romaji available";
            }

            return string.IsNullOrEmpty(hiraganaCharacters) ? "empty syllable" : $"{hiraganaCharacters} / {katakanaCharacters} ({romaji})";
        }
    }
}
