namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;
    using System.Text;

    using Wacton.Desu.Enums;

    public class KanaBase : Enumeration
    {
        public static readonly KanaBase A = new KanaBase("A", 'あ', 'ア');
        public static readonly KanaBase I = new KanaBase("I", 'い', 'イ');
        public static readonly KanaBase U = new KanaBase("U", 'う', 'ウ', 'ゔ', 'ヴ');
        public static readonly KanaBase E = new KanaBase("E", 'え', 'エ');
        public static readonly KanaBase O = new KanaBase("O", 'お', 'オ');
        public static readonly KanaBase Ka = new KanaBase("Ka", 'か', 'カ', 'が', 'ガ');
        public static readonly KanaBase Ki = new KanaBase("Ki", 'き', 'キ', 'ぎ', 'ギ');
        public static readonly KanaBase Ku = new KanaBase("Ku", 'く', 'ク', 'ぐ', 'グ');
        public static readonly KanaBase Ke = new KanaBase("Ke", 'け', 'ケ', 'げ', 'ゲ');
        public static readonly KanaBase Ko = new KanaBase("Ko", 'こ', 'コ', 'ご', 'ゴ');
        public static readonly KanaBase Sa = new KanaBase("Sa", 'さ', 'サ', 'ざ', 'ザ');
        public static readonly KanaBase Shi = new KanaBase("Shi", 'し', 'シ', 'じ', 'ジ');
        public static readonly KanaBase Su = new KanaBase("Su", 'す', 'ス', 'ず', 'ズ');
        public static readonly KanaBase Se = new KanaBase("Se", 'せ', 'セ', 'ぜ', 'ゼ');
        public static readonly KanaBase So = new KanaBase("So", 'そ', 'ソ', 'ぞ', 'ゾ');
        public static readonly KanaBase Ta = new KanaBase("Ta", 'た', 'タ', 'だ', 'ダ');
        public static readonly KanaBase Chi = new KanaBase("Chi", 'ち', 'チ', 'ぢ', 'ヂ');
        public static readonly KanaBase Tsu = new KanaBase("Tsu", 'つ', 'ツ', 'づ', 'ヅ');
        public static readonly KanaBase Te = new KanaBase("Te", 'て', 'テ', 'で', 'デ');
        public static readonly KanaBase To = new KanaBase("To", 'と', 'ト', 'ど', 'ド');
        public static readonly KanaBase Na = new KanaBase("Na", 'な', 'ナ');
        public static readonly KanaBase Ni = new KanaBase("Ni", 'に', 'ニ');
        public static readonly KanaBase Nu = new KanaBase("Nu", 'ぬ', 'ヌ');
        public static readonly KanaBase Ne = new KanaBase("Ne", 'ね', 'ネ');
        public static readonly KanaBase No = new KanaBase("No", 'の', 'ノ');
        public static readonly KanaBase Ha = new KanaBase("Ha", 'は', 'ハ', 'ば', 'バ', 'ぱ', 'パ');
        public static readonly KanaBase Hi = new KanaBase("Hi", 'ひ', 'ヒ', 'び', 'ビ', 'ぴ', 'ピ');
        public static readonly KanaBase Fu = new KanaBase("Fu", 'ふ', 'フ', 'ぶ', 'ブ', 'ぷ', 'プ');
        public static readonly KanaBase He = new KanaBase("He", 'へ', 'ヘ', 'べ', 'ベ', 'ぺ', 'ペ');
        public static readonly KanaBase Ho = new KanaBase("Ho", 'ほ', 'ホ', 'ぼ', 'ボ', 'ぽ', 'ポ');
        public static readonly KanaBase Ma = new KanaBase("Ma", 'ま', 'マ');
        public static readonly KanaBase Mi = new KanaBase("Mi", 'み', 'ミ');
        public static readonly KanaBase Mu = new KanaBase("Mu", 'む', 'ム');
        public static readonly KanaBase Me = new KanaBase("Me", 'め', 'メ');
        public static readonly KanaBase Mo = new KanaBase("Mo", 'も', 'モ');
        public static readonly KanaBase Ya = new KanaBase("Ya", 'や', 'ヤ');
        public static readonly KanaBase Yu = new KanaBase("Yu", 'ゆ', 'ユ');
        public static readonly KanaBase Yo = new KanaBase("Yo", 'よ', 'ヨ');
        public static readonly KanaBase Ra = new KanaBase("Ra", 'ら', 'ラ');
        public static readonly KanaBase Ri = new KanaBase("Ri", 'り', 'リ');
        public static readonly KanaBase Ru = new KanaBase("Ru", 'る', 'ル');
        public static readonly KanaBase Re = new KanaBase("Re", 'れ', 'レ');
        public static readonly KanaBase Ro = new KanaBase("Ro", 'ろ', 'ロ');
        public static readonly KanaBase Wa = new KanaBase("Wa", 'わ', 'ワ');
        public static readonly KanaBase Wi = new KanaBase("Wi", 'ゐ', 'ヰ');
        public static readonly KanaBase We = new KanaBase("We", 'ゑ', 'ヱ');
        public static readonly KanaBase Wo = new KanaBase("Wo", 'を', 'ヲ');
        public static readonly KanaBase N = new KanaBase("N", 'ん', 'ン');

        private readonly Dictionary<Syllabary, Dictionary<KanaType, char>> dict; 

        public KanaBase(string friendlyString, char hiraganaSeion, char katakanaSeion)
            : base(friendlyString)
        {
            this.dict = new Dictionary<Syllabary, Dictionary<KanaType, char>>();
            this.dict.Add(Syllabary.Hiragana, new Dictionary<KanaType, char>());
            this.dict.Add(Syllabary.Katakana, new Dictionary<KanaType, char>());

            this.dict[Syllabary.Hiragana].Add(KanaType.Seion, hiraganaSeion);
            this.dict[Syllabary.Katakana].Add(KanaType.Seion, katakanaSeion);
        }

        public KanaBase(string friendlyString, char hiraganaSeion, char katakanaSeion, char hiraganaDakuon, char katakanaDakuon)
             : this(friendlyString, hiraganaSeion, katakanaSeion)
        {
            this.dict[Syllabary.Hiragana].Add(KanaType.Dakuon, hiraganaDakuon);
            this.dict[Syllabary.Katakana].Add(KanaType.Dakuon, katakanaDakuon);
        }

        public KanaBase(string friendlyString, char hiraganaSeion, char katakanaSeion, char hiraganaDakuon, char katakanaDakuon, char hiraganaHandakuon, char katakanaHandakuon)
            : this(friendlyString, hiraganaSeion, katakanaSeion, hiraganaDakuon, katakanaDakuon)
        {
            this.dict[Syllabary.Hiragana].Add(KanaType.Handakuon, hiraganaHandakuon);
            this.dict[Syllabary.Katakana].Add(KanaType.Handakuon, katakanaHandakuon);
        }

        public char GetCharacter(Syllabary kanaSyllabary, KanaType kanaType)
        {
            // TODO: null checks, esp. kana types?
            return this.dict[kanaSyllabary][kanaType];
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var hiragana in this.dict[Syllabary.Hiragana])
            {
                stringBuilder.Append(hiragana.Value);
            }

            stringBuilder.Append('|');

            foreach (var katakana in this.dict[Syllabary.Katakana])
            {
                stringBuilder.Append(katakana.Value);
            }

            return $"{this.DisplayName} ({stringBuilder})";
        }
    }
}
