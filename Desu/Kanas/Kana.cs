namespace Wacton.Desu.Kanas
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    public class Kana : Enumeration
    {
        public static readonly Kana A = new Kana("A", KanaBase.A, KanaType.Seion);
        public static readonly Kana I = new Kana("I", KanaBase.I, KanaType.Seion);
        public static readonly Kana U = new Kana("U", KanaBase.U, KanaType.Seion);
        public static readonly Kana E = new Kana("E", KanaBase.E, KanaType.Seion);
        public static readonly Kana O = new Kana("O", KanaBase.O, KanaType.Seion);
        public static readonly Kana Ka = new Kana("Ka", KanaBase.Ka, KanaType.Seion);
        public static readonly Kana Ki = new Kana("Ki", KanaBase.Ki, KanaType.Seion, "Kya", "Kyu", "Kyo");
        public static readonly Kana Ku = new Kana("Ku", KanaBase.Ku, KanaType.Seion);
        public static readonly Kana Ke = new Kana("Ke", KanaBase.Ke, KanaType.Seion);
        public static readonly Kana Ko = new Kana("Ko", KanaBase.Ko, KanaType.Seion);
        public static readonly Kana Sa = new Kana("Sa", KanaBase.Sa, KanaType.Seion);
        public static readonly Kana Shi = new Kana("Shi", KanaBase.Shi, KanaType.Seion, "Sha", "Shu", "Sho");
        public static readonly Kana Su = new Kana("Su", KanaBase.Su, KanaType.Seion);
        public static readonly Kana Se = new Kana("Se", KanaBase.Se, KanaType.Seion);
        public static readonly Kana So = new Kana("So", KanaBase.So, KanaType.Seion);
        public static readonly Kana Ta = new Kana("Ta", KanaBase.Ta, KanaType.Seion);
        public static readonly Kana Chi = new Kana("Chi", KanaBase.Chi, KanaType.Seion, "Cha", "Chu", "Cho");
        public static readonly Kana Tsu = new Kana("Tsu", KanaBase.Tsu, KanaType.Seion);
        public static readonly Kana Te = new Kana("Te", KanaBase.Te, KanaType.Seion);
        public static readonly Kana To = new Kana("To", KanaBase.To, KanaType.Seion);
        public static readonly Kana Na = new Kana("Na", KanaBase.Na, KanaType.Seion);
        public static readonly Kana Ni = new Kana("Ni", KanaBase.Ni, KanaType.Seion, "Nya", "Nyu", "Nyo");
        public static readonly Kana Nu = new Kana("Nu", KanaBase.Nu, KanaType.Seion);
        public static readonly Kana Ne = new Kana("Ne", KanaBase.Ne, KanaType.Seion);
        public static readonly Kana No = new Kana("No", KanaBase.No, KanaType.Seion);
        public static readonly Kana Ha = new Kana("Ha", KanaBase.Ha, KanaType.Seion);
        public static readonly Kana Hi = new Kana("Hi", KanaBase.Hi, KanaType.Seion, "Hya", "Hyu", "Hyo");
        public static readonly Kana Fu = new Kana("Fu", KanaBase.Fu, KanaType.Seion);
        public static readonly Kana He = new Kana("He", KanaBase.He, KanaType.Seion);
        public static readonly Kana Ho = new Kana("Ho", KanaBase.Ho, KanaType.Seion);
        public static readonly Kana Ma = new Kana("Ma", KanaBase.Ma, KanaType.Seion);
        public static readonly Kana Mi = new Kana("Mi", KanaBase.Mi, KanaType.Seion, "Mya", "Myu", "Myo");
        public static readonly Kana Mu = new Kana("Mu", KanaBase.Mu, KanaType.Seion);
        public static readonly Kana Me = new Kana("Me", KanaBase.Me, KanaType.Seion);
        public static readonly Kana Mo = new Kana("Mo", KanaBase.Mo, KanaType.Seion);
        public static readonly Kana Ya = new Kana("Ya", KanaBase.Ya, KanaType.Seion);
        public static readonly Kana Yu = new Kana("Yu", KanaBase.Yu, KanaType.Seion);
        public static readonly Kana Yo = new Kana("Yo", KanaBase.Yo, KanaType.Seion);
        public static readonly Kana Ra = new Kana("Ra", KanaBase.Ra, KanaType.Seion);
        public static readonly Kana Ri = new Kana("Ri", KanaBase.Ri, KanaType.Seion, "Rya", "Ryu", "Ryo");
        public static readonly Kana Ru = new Kana("Ru", KanaBase.Ru, KanaType.Seion);
        public static readonly Kana Re = new Kana("Re", KanaBase.Re, KanaType.Seion);
        public static readonly Kana Ro = new Kana("Ro", KanaBase.Ro, KanaType.Seion);
        public static readonly Kana Wa = new Kana("Wa", KanaBase.Wa, KanaType.Seion);
        public static readonly Kana Wi = new Kana("Wi", KanaBase.Wi, KanaType.Seion);
        public static readonly Kana We = new Kana("We", KanaBase.We, KanaType.Seion);
        public static readonly Kana Wo = new Kana("Wo", KanaBase.Wo, KanaType.Seion);
        public static readonly Kana N = new Kana("N", KanaBase.N, KanaType.Seion); // note: ん/ン before b/p/m is often recorded as 'm', but largely insignificant

        public static readonly Kana Ga = new Kana("Ga", KanaBase.Ka, KanaType.Dakuon);
        public static readonly Kana Gi = new Kana("Gi", KanaBase.Ki, KanaType.Dakuon, "Gya", "Gyu", "Gyo");
        public static readonly Kana Gu = new Kana("Gu", KanaBase.Ku, KanaType.Dakuon);
        public static readonly Kana Ge = new Kana("Ge", KanaBase.Ke, KanaType.Dakuon);
        public static readonly Kana Go = new Kana("Go", KanaBase.Ko, KanaType.Dakuon);
        public static readonly Kana Za = new Kana("Za", KanaBase.Sa, KanaType.Dakuon);
        public static readonly Kana Ji = new Kana("Ji", KanaBase.Shi, KanaType.Dakuon, "Ja", "Ju", "Jo");
        public static readonly Kana Zu = new Kana("Zu", KanaBase.Su, KanaType.Dakuon);
        public static readonly Kana Ze = new Kana("Ze", KanaBase.Se, KanaType.Dakuon);
        public static readonly Kana Zo = new Kana("Zo", KanaBase.So, KanaType.Dakuon);
        public static readonly Kana Da = new Kana("Da", KanaBase.Ta, KanaType.Dakuon);
        public static readonly Kana Dji = new Kana("Dji", KanaBase.Chi, KanaType.Dakuon, "Dja", "Dju", "Djo");
        public static readonly Kana Dzu = new Kana("Dzu", KanaBase.Tsu, KanaType.Dakuon);
        public static readonly Kana De = new Kana("De", KanaBase.Te, KanaType.Dakuon);
        public static readonly Kana Do = new Kana("Do", KanaBase.To, KanaType.Dakuon);
        public static readonly Kana Ba = new Kana("Ba", KanaBase.Ha, KanaType.Dakuon);
        public static readonly Kana Bi = new Kana("Bi", KanaBase.Hi, KanaType.Dakuon, "Bya", "Byu", "Byo");
        public static readonly Kana Bu = new Kana("Bu", KanaBase.Fu, KanaType.Dakuon);
        public static readonly Kana Be = new Kana("Be", KanaBase.He, KanaType.Dakuon);
        public static readonly Kana Bo = new Kana("Bo", KanaBase.Ho, KanaType.Dakuon);
        public static readonly Kana Pa = new Kana("Pa", KanaBase.Ha, KanaType.Handakuon);
        public static readonly Kana Pi = new Kana("Pi", KanaBase.Hi, KanaType.Handakuon, "Pya", "Pyu", "Pyo");
        public static readonly Kana Pu = new Kana("Pu", KanaBase.Fu, KanaType.Handakuon);
        public static readonly Kana Pe = new Kana("Pe", KanaBase.He, KanaType.Handakuon);
        public static readonly Kana Po = new Kana("Po", KanaBase.Ho, KanaType.Handakuon);

        public static readonly Kana Vu = new Kana("Vu", KanaBase.U, KanaType.Dakuon);

        private string Romaji { get; }
        private KanaBase KanaBase { get; }
        private KanaType KanaType { get; }
        private Dictionary<Youon, string> YouonRomaji { get; }

        private readonly string[] vowels = { "a", "e", "i", "o", "u" };

        public Kana(string romaji, KanaBase kanaBase, KanaType kanaType)
            : base(romaji)
        {
            this.Romaji = romaji;
            this.KanaBase = kanaBase;
            this.KanaType = kanaType;
            this.YouonRomaji = new Dictionary<Youon, string>();
        }

        public Kana(string romaji, KanaBase kanaBase, KanaType kanaType, string yaRomaji, string yuRomaji, string yoRomaji)
            : this(romaji, kanaBase, kanaType)
        {
            this.YouonRomaji.Add(Youon.Ya, yaRomaji);
            this.YouonRomaji.Add(Youon.Yu, yuRomaji);
            this.YouonRomaji.Add(Youon.Yo, yoRomaji);
        }

        public char GetCharacter(Syllabary kanaSyllabary)
        {
            return this.KanaBase.GetCharacter(kanaSyllabary, this.KanaType);
        }

        public char GetCharacter(Syllabary kanaSyllabary, KanaType kanaType)
        {
            return this.KanaBase.GetCharacter(kanaSyllabary, kanaType);
        }

        public string GetRomaji(bool chouon, bool sokuon)
        {
            return this.ApplyModifications(this.Romaji, chouon, sokuon);
        }

        public string GetRomaji(Youon youon, bool chouon, bool sokuon)
        {
            var romaji = this.GetYouonRomaji(youon);
            romaji = this.ApplyModifications(romaji, chouon, sokuon);
            return romaji;
        }

        public string GetRomaji(Tokushuon youon, bool chouon, bool sokuon)
        {
            var romaji = this.GetTokushonRomaji(youon);
            romaji = this.ApplyModifications(romaji, chouon, sokuon);
            return romaji;
        }

        private string GetYouonRomaji(Youon youon)
        {
            if (this.YouonRomaji.ContainsKey(youon))
            {
                return this.YouonRomaji[youon];
            }

            var lastCharacter = this.Romaji.Last().ToString();
            var replacementString = youon.GetRomaji().ToLower();
            return this.Romaji.Replace(lastCharacter, replacementString);
        }

        private string GetTokushonRomaji(Tokushuon tokushuon)
        {
            var lastCharacter = this.Romaji.Last().ToString();
            var replacement = tokushuon.GetRomaji().ToLower();
            if (this.vowels.Contains(lastCharacter))
            {
                return this.Romaji.Replace(lastCharacter, replacement);
            }

            return this.Romaji + replacement;
        }

        private string ApplyModifications(string romaji, bool chouon, bool sokuon)
        {
            if (chouon)
            {
                var vowel = romaji.Last();
                romaji = romaji + vowel;
            }

            if (sokuon)
            {
                var consonant = romaji.First();
                if (consonant.Equals('C'))
                {
                    consonant = 'T';
                }

                romaji = consonant + romaji;
            }

            return romaji;
        }
    }
}
