namespace Wacton.Desu.Enums
{
    using System.Collections.Generic;
    using System.Linq;

    public class PartOfSpeech : Enumeration
    {
        public static readonly PartOfSpeech AdjectiveI = new PartOfSpeech(nameof(AdjectiveI), "adjective (keiyoushi)", "Adjective (i)");
        public static readonly PartOfSpeech AdjectiveIi = new PartOfSpeech(nameof(AdjectiveIi), "adjective (keiyoushi) - yoi/ii class", "Adjective (yo/ii)");
        public static readonly PartOfSpeech AdjectiveKu = new PartOfSpeech(nameof(AdjectiveKu), "'ku' adjective (archaic)", "Adjective (ku) [archaic]");
        public static readonly PartOfSpeech AdjectiveNa = new PartOfSpeech(nameof(AdjectiveNa), "adjectival nouns or quasi-adjectives (keiyodoshi)", "Adjective (na)");
        public static readonly PartOfSpeech AdjectiveNari = new PartOfSpeech(nameof(AdjectiveNari), "archaic/formal form of na-adjective", "Adjective (nari)");
        public static readonly PartOfSpeech AdjectivePrenominally = new PartOfSpeech(nameof(AdjectivePrenominally), "noun or verb acting prenominally", "Noun or verb acting prenominally");
        public static readonly PartOfSpeech AdjectivePreNoun = new PartOfSpeech(nameof(AdjectivePreNoun), "pre-noun adjectival (rentaishi)", "Pre-noun adjectival");
        public static readonly PartOfSpeech AdjectiveShiku = new PartOfSpeech(nameof(AdjectiveShiku), "'shiku' adjective (archaic)", "Adjective (shiku)");
        public static readonly PartOfSpeech AdjectiveTaru = new PartOfSpeech(nameof(AdjectiveTaru), "'taru' adjective", "Adjective (taru)");
        public static readonly PartOfSpeech Adverb = new PartOfSpeech(nameof(Adverb), "adverb (fukushi)", "Adverb");
        public static readonly PartOfSpeech AdverbTo = new PartOfSpeech(nameof(AdverbTo), "adverb taking the 'to' particle", "Adverb (takes 'to' particle)");
        public static readonly PartOfSpeech Auxiliary = new PartOfSpeech(nameof(Auxiliary), "auxiliary", "Auxiliary");
        public static readonly PartOfSpeech AuxiliaryAdjective = new PartOfSpeech(nameof(AuxiliaryAdjective), "auxiliary adjective", "Auxiliary adjective");
        public static readonly PartOfSpeech AuxiliaryVerb = new PartOfSpeech(nameof(AuxiliaryVerb), "auxiliary verb", "Auxiliary verb");
        public static readonly PartOfSpeech Conjunction = new PartOfSpeech(nameof(Conjunction), "conjunction", "Conjugation");
        public static readonly PartOfSpeech Copula = new PartOfSpeech(nameof(Copula), "copula", "Copula");
        public static readonly PartOfSpeech Counter = new PartOfSpeech(nameof(Counter), "counter", "Counter");
        public static readonly PartOfSpeech Expression = new PartOfSpeech(nameof(Expression), "expressions (phrases, clauses, etc.)", "Expression");
        public static readonly PartOfSpeech Interjection = new PartOfSpeech(nameof(Interjection), "interjection (kandoushi)", "Interjection");
        public static readonly PartOfSpeech NounAdverbial = new PartOfSpeech(nameof(NounAdverbial), "adverbial noun (fukushitekimeishi)", "Noun (adverbial)");
        public static readonly PartOfSpeech NounCommon = new PartOfSpeech(nameof(NounCommon), "noun (common) (futsuumeishi)", "Noun (common)");
        public static readonly PartOfSpeech NounNo = new PartOfSpeech(nameof(NounNo), "nouns which may take the genitive case particle 'no'", "Noun (may take 'no' genitive case particle)");
        public static readonly PartOfSpeech NounPrefix = new PartOfSpeech(nameof(NounPrefix), "noun, used as a prefix", "Noun (used as prefix)");
        public static readonly PartOfSpeech NounSuffix = new PartOfSpeech(nameof(NounSuffix), "noun, used as a suffix", "Noun (used as suffix)");
        public static readonly PartOfSpeech NounSuru = new PartOfSpeech(nameof(NounSuru), "noun or participle which takes the aux. verb suru", "Noun (takes 'suru' aux. verb)");
        public static readonly PartOfSpeech NounTemporal = new PartOfSpeech(nameof(NounTemporal), "noun (temporal) (jisoumeishi)", "Noun (temporal)");
        public static readonly PartOfSpeech Numeric = new PartOfSpeech(nameof(Numeric), "numeric", "Numeric");
        public static readonly PartOfSpeech Particle = new PartOfSpeech(nameof(Particle), "particle", "Particle");
        public static readonly PartOfSpeech Prefix = new PartOfSpeech(nameof(Prefix), "prefix", "Prefix");
        public static readonly PartOfSpeech Pronoun = new PartOfSpeech(nameof(Pronoun), "pronoun", "Pronoun");
        public static readonly PartOfSpeech Suffix = new PartOfSpeech(nameof(Suffix), "suffix", "Suffix");
        public static readonly PartOfSpeech Unclassified = new PartOfSpeech(nameof(Unclassified), "unclassified", "Unclassified");
        public static readonly PartOfSpeech Verb1 = new PartOfSpeech(nameof(Verb1), "Ichidan verb", "Verb (ichidan)");
        public static readonly PartOfSpeech Verb1KureruSpecial = new PartOfSpeech(nameof(Verb1KureruSpecial), "Ichidan verb - kureru special class", "Verb (ichidan, kureru special)");
        public static readonly PartOfSpeech Verb1Zuru = new PartOfSpeech(nameof(Verb1Zuru), "Ichidan verb - zuru verb (alternative form of -jiru verbs)", "Verb (ichidan, zuru)");
        public static readonly PartOfSpeech Verb2BuUpper = new PartOfSpeech(nameof(Verb2BuUpper), "Nidan verb (upper class) with 'bu' ending (archaic)", "Verb (nidan, upper, bu) [archaic]");
        public static readonly PartOfSpeech Verb2DzuLower = new PartOfSpeech(nameof(Verb2DzuLower), "Nidan verb (lower class) with 'dzu' ending (archaic)", "Verb (nidan, lower, dzu) [archaic]");
        public static readonly PartOfSpeech Verb2FuLower = new PartOfSpeech(nameof(Verb2FuLower), "Nidan verb (lower class) with 'hu/fu' ending (archaic)", "Verb (nidan, lower, hu/fu) [archaic]");
        public static readonly PartOfSpeech Verb2FuUpper = new PartOfSpeech(nameof(Verb2FuUpper), "Nidan verb (upper class) with 'hu/fu' ending (archaic)", "Verb (nidan, upper, hu/fu) [archaic]");
        public static readonly PartOfSpeech Verb2GuLower = new PartOfSpeech(nameof(Verb2GuLower), "Nidan verb (lower class) with 'gu' ending (archaic)", "Verb (nidan, lower, gu) [archaic]");
        public static readonly PartOfSpeech Verb2GuUpper = new PartOfSpeech(nameof(Verb2GuUpper), "Nidan verb (upper class) with 'gu' ending (archaic)", "Verb (nidan, upper, gu) [archaic]");
        public static readonly PartOfSpeech Verb2KuLower = new PartOfSpeech(nameof(Verb2KuLower), "Nidan verb (lower class) with 'ku' ending (archaic)", "Verb (nidan, lower, ku) [archaic]");
        public static readonly PartOfSpeech Verb2KuUpper = new PartOfSpeech(nameof(Verb2KuUpper), "Nidan verb (upper class) with 'ku' ending (archaic)", "Verb (nidan, upper, ku) [archaic]");
        public static readonly PartOfSpeech Verb2MuLower = new PartOfSpeech(nameof(Verb2MuLower), "Nidan verb (lower class) with 'mu' ending (archaic)", "Verb (nidan, lower, mu) [archaic]");
        public static readonly PartOfSpeech Verb2NuLower = new PartOfSpeech(nameof(Verb2NuLower), "Nidan verb (lower class) with 'nu' ending (archaic)", "Verb (nidan, upper, mu) [archaic]");
        public static readonly PartOfSpeech Verb2RuLower = new PartOfSpeech(nameof(Verb2RuLower), "Nidan verb (lower class) with 'ru' ending (archaic)", "Verb (nidan, lower, ru) [archaic]");
        public static readonly PartOfSpeech Verb2RuUpper = new PartOfSpeech(nameof(Verb2RuUpper), "Nidan verb (upper class) with 'ru' ending (archaic)", "Verb (nidan, upper, ru) [archaic]");
        public static readonly PartOfSpeech Verb2SuLower = new PartOfSpeech(nameof(Verb2SuLower), "Nidan verb (lower class) with 'su' ending (archaic)", "Verb (nidan, lower, su) [archaic]");
        public static readonly PartOfSpeech Verb2TsuLower = new PartOfSpeech(nameof(Verb2TsuLower), "Nidan verb (lower class) with 'tsu' ending (archaic)", "Verb (nidan, lower, tsu) [archaic]");
        public static readonly PartOfSpeech Verb2TsuUpper = new PartOfSpeech(nameof(Verb2TsuUpper), "Nidan verb (upper class) with 'tsu' ending (archaic)", "Verb (nidan, upper, tsu) [archaic]");
        public static readonly PartOfSpeech Verb2U = new PartOfSpeech(nameof(Verb2U), "Nidan verb with 'u' ending (archaic)", "Verb (nidan, u) [archaic]");
        public static readonly PartOfSpeech Verb2ULower = new PartOfSpeech(nameof(Verb2ULower), "Nidan verb (lower class) with 'u' ending and 'we' conjugation (archaic)", "Verb (nidan, lower, u, we conjugation) [archaic]");
        public static readonly PartOfSpeech Verb2YuLower = new PartOfSpeech(nameof(Verb2YuLower), "Nidan verb (lower class) with 'yu' ending (archaic)", "Verb (nidan, lower, yu) [archaic]");
        public static readonly PartOfSpeech Verb2YuUpper = new PartOfSpeech(nameof(Verb2YuUpper), "Nidan verb (upper class) with 'yu' ending (archaic)", "Verb (nidan, upper, yu) [archaic]");
        public static readonly PartOfSpeech Verb2ZuLower = new PartOfSpeech(nameof(Verb2ZuLower), "Nidan verb (lower class) with 'zu' ending (archaic)", "Verb (nidan, lower, zu) [archaic]");
        public static readonly PartOfSpeech Verb4Bu = new PartOfSpeech(nameof(Verb4Bu), "Yodan verb with 'bu' ending (archaic)", "Verb (yodan, bu) [archaic]");
        public static readonly PartOfSpeech Verb4Fu = new PartOfSpeech(nameof(Verb4Fu), "Yodan verb with 'hu/fu' ending (archaic)", "Verb (yodan, hu/fu) [archaic]");
        public static readonly PartOfSpeech Verb4Gu = new PartOfSpeech(nameof(Verb4Gu), "Yodan verb with 'gu' ending (archaic)", "Verb (yodan, gu) [archaic]");
        public static readonly PartOfSpeech Verb4Ku = new PartOfSpeech(nameof(Verb4Ku), "Yodan verb with 'ku' ending (archaic)", "Verb (yodan, ku) [archaic]");
        public static readonly PartOfSpeech Verb4Mu = new PartOfSpeech(nameof(Verb4Mu), "Yodan verb with 'mu' ending (archaic)", "Verb (yodan, mu) [archaic]");
        public static readonly PartOfSpeech Verb4Ru = new PartOfSpeech(nameof(Verb4Ru), "Yodan verb with 'ru' ending (archaic)", "Verb (yodan, ru) [archaic]");
        public static readonly PartOfSpeech Verb4Su = new PartOfSpeech(nameof(Verb4Su), "Yodan verb with 'su' ending (archaic)", "Verb (yodan, su) [archaic]");
        public static readonly PartOfSpeech Verb4Tsu = new PartOfSpeech(nameof(Verb4Tsu), "Yodan verb with 'tsu' ending (archaic)", "Verb (yodan, tsu) [archaic]");
        public static readonly PartOfSpeech Verb5AruSpecial = new PartOfSpeech(nameof(Verb5AruSpecial), "Godan verb - -aru special class", "Verb (godan, aru special)");
        public static readonly PartOfSpeech Verb5Bu = new PartOfSpeech(nameof(Verb5Bu), "Godan verb with 'bu' ending", "Verb (godan, bu)");
        public static readonly PartOfSpeech Verb5Gu = new PartOfSpeech(nameof(Verb5Gu), "Godan verb with 'gu' ending", "Verb (godan, gu)");
        public static readonly PartOfSpeech Verb5IkuSpecial = new PartOfSpeech(nameof(Verb5IkuSpecial), "Godan verb - Iku/Yuku special class", "Verb (godan, iku/yuku special)");
        public static readonly PartOfSpeech Verb5Ku = new PartOfSpeech(nameof(Verb5Ku), "Godan verb with 'ku' ending", "Verb (godan, ku)");
        public static readonly PartOfSpeech Verb5Mu = new PartOfSpeech(nameof(Verb5Mu), "Godan verb with 'mu' ending", "Verb (godan, mu)");
        public static readonly PartOfSpeech Verb5Nu = new PartOfSpeech(nameof(Verb5Nu), "Godan verb with 'nu' ending", "Verb (godan, nu)");
        public static readonly PartOfSpeech Verb5Ru = new PartOfSpeech(nameof(Verb5Ru), "Godan verb with 'ru' ending", "Verb (godan, ru)");
        public static readonly PartOfSpeech Verb5RuIrregular = new PartOfSpeech(nameof(Verb5RuIrregular), "Godan verb with 'ru' ending (irregular verb)", "Verb (godan, ru, irregular)");
        public static readonly PartOfSpeech Verb5Su = new PartOfSpeech(nameof(Verb5Su), "Godan verb with 'su' ending", "Verb (godan, su)");
        public static readonly PartOfSpeech Verb5Tsu = new PartOfSpeech(nameof(Verb5Tsu), "Godan verb with 'tsu' ending", "Verb (godan, tsu)");
        public static readonly PartOfSpeech Verb5U = new PartOfSpeech(nameof(Verb5U), "Godan verb with 'u' ending", "Verb (godan, u)");
        public static readonly PartOfSpeech Verb5USpecial = new PartOfSpeech(nameof(Verb5USpecial), "Godan verb with 'u' ending (special class)", "Verb (godan, u special)");
        public static readonly PartOfSpeech VerbIntransitive = new PartOfSpeech(nameof(VerbIntransitive), "intransitive verb", "Verb (intransitive)");
        public static readonly PartOfSpeech VerbKuSpecial = new PartOfSpeech(nameof(VerbKuSpecial), "Kuru verb - special class", "Verb (kuru special)");
        public static readonly PartOfSpeech VerbNuIrregular = new PartOfSpeech(nameof(VerbNuIrregular), "irregular nu verb", "Verb (nu, irregular)");
        public static readonly PartOfSpeech VerbRuIrregular = new PartOfSpeech(nameof(VerbRuIrregular), "irregular ru verb, plain form ends with -ri", "Verb (ru, irregular) [plain form ends -ri]");
        public static readonly PartOfSpeech VerbSu = new PartOfSpeech(nameof(VerbSu), "su verb - precursor to the modern suru", "Verb (su) [precursor to modern suru]");
        public static readonly PartOfSpeech VerbSuruIncluded = new PartOfSpeech(nameof(VerbSuruIncluded), "suru verb - included", "Verb (suru, included)");
        public static readonly PartOfSpeech VerbSuruSpecial = new PartOfSpeech(nameof(VerbSuruSpecial), "suru verb - special class", "Verb (suru, special)");
        public static readonly PartOfSpeech VerbTransitive = new PartOfSpeech(nameof(VerbTransitive), "transitive verb", "Verb (transitive)");
        public static readonly PartOfSpeech VerbUnspecified = new PartOfSpeech(nameof(VerbUnspecified), "verb unspecified", "Verb (unspecified)");

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
        public string Description { get; }

        public PartOfSpeech(string displayName, string code, string description = null)
            : base(displayName)
        {
            this.Code = code;
            this.Description = description ?? this.Code;
        }

        public override string ToString() => this.Description;
    }
}