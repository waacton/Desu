namespace Wacton.Desu
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Tovarisch.Enum;

    public class PartOfSpeech : Enumeration
    {
        public static readonly PartOfSpeech AdjectiveI = new PartOfSpeech("AdjectiveI", "adjective (keiyoushi)");
        public static readonly PartOfSpeech AdjectiveIi = new PartOfSpeech("AdjectiveIi", "adjective (keiyoushi) - yoi/ii class");
        public static readonly PartOfSpeech AdjectiveKu = new PartOfSpeech("AdjectiveKu", "`ku' adjective (archaic)");
        public static readonly PartOfSpeech AdjectiveNa = new PartOfSpeech("AdjectiveNa", "adjectival nouns or quasi-adjectives (keiyodoshi)");
        public static readonly PartOfSpeech AdjectiveNari = new PartOfSpeech("AdjectiveNari", "archaic/formal form of na-adjective");
        public static readonly PartOfSpeech AdjectivePrenominally = new PartOfSpeech("AdjectivePrenominally", "noun or verb acting prenominally");
        public static readonly PartOfSpeech AdjectivePreNoun = new PartOfSpeech("AdjectivePreNoun", "pre-noun adjectival (rentaishi)");
        public static readonly PartOfSpeech AdjectiveShiku = new PartOfSpeech("AdjectiveShiku", "`shiku' adjective (archaic)");
        public static readonly PartOfSpeech AdjectiveTaru = new PartOfSpeech("AdjectiveTaru", "`taru' adjective");
        public static readonly PartOfSpeech Adverb = new PartOfSpeech("Adverb", "adverb (fukushi)");
        public static readonly PartOfSpeech AdverbTo = new PartOfSpeech("AdverbTo", "adverb taking the `to' particle");
        public static readonly PartOfSpeech Auxiliary = new PartOfSpeech("Auxiliary", "auxiliary");
        public static readonly PartOfSpeech AuxiliaryAdjective = new PartOfSpeech("AuxiliaryAdjective", "auxiliary adjective");
        public static readonly PartOfSpeech AuxiliaryVerb = new PartOfSpeech("AuxiliaryVerb", "auxiliary verb");
        public static readonly PartOfSpeech Conjunction = new PartOfSpeech("Conjunction", "conjunction");
        public static readonly PartOfSpeech Copula = new PartOfSpeech("Copula", "copula");
        public static readonly PartOfSpeech Counter = new PartOfSpeech("Counter", "counter");
        public static readonly PartOfSpeech Expression = new PartOfSpeech("Expression", "expressions (phrases, clauses, etc.)");
        public static readonly PartOfSpeech Interjection = new PartOfSpeech("Interjection", "interjection (kandoushi)");
        public static readonly PartOfSpeech NounAdverbial = new PartOfSpeech("NounAdverbial", "adverbial noun (fukushitekimeishi)");
        public static readonly PartOfSpeech NounCommon = new PartOfSpeech("NounCommon", "noun (common) (futsuumeishi)");
        public static readonly PartOfSpeech NounNo = new PartOfSpeech("NounNo", "nouns which may take the genitive case particle `no'");
        public static readonly PartOfSpeech NounPrefix = new PartOfSpeech("NounPrefix", "noun, used as a prefix");
        public static readonly PartOfSpeech NounSuffix = new PartOfSpeech("NounSuffix", "noun, used as a suffix");
        public static readonly PartOfSpeech NounSuru = new PartOfSpeech("NounSuru", "noun or participle which takes the aux. verb suru");
        public static readonly PartOfSpeech NounTemporal = new PartOfSpeech("NounTemporal", "noun (temporal) (jisoumeishi)");
        public static readonly PartOfSpeech Numeric = new PartOfSpeech("Numeric", "numeric");
        public static readonly PartOfSpeech Particle = new PartOfSpeech("Particle", "particle");
        public static readonly PartOfSpeech Prefix = new PartOfSpeech("Prefix", "prefix");
        public static readonly PartOfSpeech Pronoun = new PartOfSpeech("Pronoun", "pronoun");
        public static readonly PartOfSpeech ProperNoun = new PartOfSpeech("ProperNoun", "proper noun");
        public static readonly PartOfSpeech Suffix = new PartOfSpeech("Suffix", "suffix");
        public static readonly PartOfSpeech Unclassified = new PartOfSpeech("Unclassified", "unclassified");
        public static readonly PartOfSpeech Verb1 = new PartOfSpeech("Verb1", "Ichidan verb");
        public static readonly PartOfSpeech Verb1KureruSpecial = new PartOfSpeech("Verb1KureruSpecial", "Ichidan verb - kureru special class");
        public static readonly PartOfSpeech Verb1Zuru = new PartOfSpeech("Verb1Zuru", "Ichidan verb - zuru verb (alternative form of -jiru verbs)");
        public static readonly PartOfSpeech Verb2BuUpper = new PartOfSpeech("Verb2BuUpper", "Nidan verb (upper class) with `bu' ending (archaic)");
        public static readonly PartOfSpeech Verb2DzuLower = new PartOfSpeech("Verb2DzuLower", "Nidan verb (lower class) with `dzu' ending (archaic)");
        public static readonly PartOfSpeech Verb2FuLower = new PartOfSpeech("Verb2FuLower", "Nidan verb (lower class) with `hu/fu' ending (archaic)");
        public static readonly PartOfSpeech Verb2FuUpper = new PartOfSpeech("Verb2FuUpper", "Nidan verb (upper class) with `hu/fu' ending (archaic)");
        public static readonly PartOfSpeech Verb2GuLower = new PartOfSpeech("Verb2GuLower", "Nidan verb (lower class) with `gu' ending (archaic)");
        public static readonly PartOfSpeech Verb2GuUpper = new PartOfSpeech("Verb2GuUpper", "Nidan verb (upper class) with `gu' ending (archaic)");
        public static readonly PartOfSpeech Verb2KuLower = new PartOfSpeech("Verb2KuLower", "Nidan verb (lower class) with `ku' ending (archaic)");
        public static readonly PartOfSpeech Verb2KuUpper = new PartOfSpeech("Verb2KuUpper", "Nidan verb (upper class) with `ku' ending (archaic)");
        public static readonly PartOfSpeech Verb2MuLower = new PartOfSpeech("Verb2MuLower", "Nidan verb (lower class) with `mu' ending (archaic)");
        public static readonly PartOfSpeech Verb2NuLower = new PartOfSpeech("Verb2NuLower", "Nidan verb (lower class) with `nu' ending (archaic)");
        public static readonly PartOfSpeech Verb2RuLower = new PartOfSpeech("Verb2RuLower", "Nidan verb (lower class) with `ru' ending (archaic)");
        public static readonly PartOfSpeech Verb2RuUpper = new PartOfSpeech("Verb2RuUpper", "Nidan verb (upper class) with `ru' ending (archaic)");
        public static readonly PartOfSpeech Verb2SuLower = new PartOfSpeech("Verb2SuLower", "Nidan verb (lower class) with `su' ending (archaic)");
        public static readonly PartOfSpeech Verb2TsuLower = new PartOfSpeech("Verb2TsuLower", "Nidan verb (lower class) with `tsu' ending (archaic)");
        public static readonly PartOfSpeech Verb2TsuUpper = new PartOfSpeech("Verb2TsuUpper", "Nidan verb (upper class) with `tsu' ending (archaic)");
        public static readonly PartOfSpeech Verb2U = new PartOfSpeech("Verb2U", "Nidan verb with 'u' ending (archaic)");
        public static readonly PartOfSpeech Verb2ULower = new PartOfSpeech("Verb2ULower", "Nidan verb (lower class) with `u' ending and `we' conjugation (archaic)");
        public static readonly PartOfSpeech Verb2YuLower = new PartOfSpeech("Verb2YuLower", "Nidan verb (lower class) with `yu' ending (archaic)");
        public static readonly PartOfSpeech Verb2YuUpper = new PartOfSpeech("Verb2YuUpper", "Nidan verb (upper class) with `yu' ending (archaic)");
        public static readonly PartOfSpeech Verb2ZuLower = new PartOfSpeech("Verb2ZuLower", "Nidan verb (lower class) with `zu' ending (archaic)");
        public static readonly PartOfSpeech Verb4Bu = new PartOfSpeech("Verb4Bu", "Yodan verb with `bu' ending (archaic)");
        public static readonly PartOfSpeech Verb4Fu = new PartOfSpeech("Verb4Fu", "Yodan verb with `hu/fu' ending (archaic)");
        public static readonly PartOfSpeech Verb4Ku = new PartOfSpeech("Verb4Ku", "Yodan verb with `ku' ending (archaic)");
        public static readonly PartOfSpeech Verb4Mu = new PartOfSpeech("Verb4Mu", "Yodan verb with `mu' ending (archaic)");
        public static readonly PartOfSpeech Verb4Ru = new PartOfSpeech("Verb4Ru", "Yodan verb with `ru' ending (archaic)");
        public static readonly PartOfSpeech Verb4Su = new PartOfSpeech("Verb4Su", "Yodan verb with `su' ending (archaic)");
        public static readonly PartOfSpeech Verb4Tsu = new PartOfSpeech("Verb4Tsu", "Yodan verb with `tsu' ending (archaic)");
        public static readonly PartOfSpeech Verb5AruSpecial = new PartOfSpeech("Verb5AruSpecial", "Godan verb - -aru special class");
        public static readonly PartOfSpeech Verb5Bu = new PartOfSpeech("Verb5Bu", "Godan verb with `bu' ending");
        public static readonly PartOfSpeech Verb5Gu = new PartOfSpeech("Verb5Gu", "Godan verb with `gu' ending");
        public static readonly PartOfSpeech Verb5IkuSpecial = new PartOfSpeech("Verb5IkuSpecial", "Godan verb - Iku/Yuku special class");
        public static readonly PartOfSpeech Verb5Ku = new PartOfSpeech("Verb5Ku", "Godan verb with `ku' ending");
        public static readonly PartOfSpeech Verb5Mu = new PartOfSpeech("Verb5Mu", "Godan verb with `mu' ending");
        public static readonly PartOfSpeech Verb5Nu = new PartOfSpeech("Verb5Nu", "Godan verb with `nu' ending");
        public static readonly PartOfSpeech Verb5Ru = new PartOfSpeech("Verb5Ru", "Godan verb with `ru' ending");
        public static readonly PartOfSpeech Verb5RuIrregular = new PartOfSpeech("Verb5RuIrregular", "Godan verb with `ru' ending (irregular verb)");
        public static readonly PartOfSpeech Verb5Su = new PartOfSpeech("Verb5Su", "Godan verb with `su' ending");
        public static readonly PartOfSpeech Verb5Tsu = new PartOfSpeech("Verb5Tsu", "Godan verb with `tsu' ending");
        public static readonly PartOfSpeech Verb5U = new PartOfSpeech("Verb5U", "Godan verb with `u' ending");
        public static readonly PartOfSpeech Verb5USpecial = new PartOfSpeech("Verb5USpecial", "Godan verb with `u' ending (special class)");
        public static readonly PartOfSpeech VerbIntransitive = new PartOfSpeech("VerbIntransitive", "intransitive verb");
        public static readonly PartOfSpeech VerbKuSpecial = new PartOfSpeech("VerbKuSpecial", "Kuru verb - special class");
        public static readonly PartOfSpeech VerbNuIrregular = new PartOfSpeech("VerbNuIrregular", "irregular nu verb");
        public static readonly PartOfSpeech VerbRuIrregular = new PartOfSpeech("VerbRuIrregular", "irregular ru verb, plain form ends with -ri");
        public static readonly PartOfSpeech VerbSu = new PartOfSpeech("VerbSu", "su verb - precursor to the modern suru");
        public static readonly PartOfSpeech VerbSuruIrregular = new PartOfSpeech("VerbSuruIrregular", "suru verb - irregular");
        public static readonly PartOfSpeech VerbSuruSpecial = new PartOfSpeech("VerbSuruSpecial", "suru verb - special class");
        public static readonly PartOfSpeech VerbTransitive = new PartOfSpeech("VerbTransitive", "transitive verb");

        public static readonly IEnumerable<PartOfSpeech> Adjectives = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Adjective"));
        public static readonly IEnumerable<PartOfSpeech> Adverbs = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Adverb"));
        public static readonly IEnumerable<PartOfSpeech> Auxiliaries = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Auxiliary"));
        public static readonly IEnumerable<PartOfSpeech> Nouns = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Noun"));
        public static readonly IEnumerable<PartOfSpeech> Verbs = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Verb"));
        public static readonly IEnumerable<PartOfSpeech> VerbsIchidan = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Verb1"));
        public static readonly IEnumerable<PartOfSpeech> VerbsNidan = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Verb2"));
        public static readonly IEnumerable<PartOfSpeech> VerbsYodan = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Verb4"));
        public static readonly IEnumerable<PartOfSpeech> VerbsGodan = GetAll<PartOfSpeech>().Where(partOfSpeech => partOfSpeech.DisplayName.StartsWith("Verb5"));

        public string Code { get; }

        private static int counter;
        public PartOfSpeech(string displayName, string code)
            : base(counter++, displayName)
        {
            this.Code = code;
        }
    }
}