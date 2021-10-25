namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/jmdictdb/cgi-bin/edhelp.py?svc=jmdict&sid=#kwabbr (Fld)
    public class Field : Enumeration
    {
        public static readonly Field Agriculture = new Field(nameof(Agriculture), "agriculture");
        public static readonly Field Anatomy = new Field(nameof(Anatomy), "anatomy");
        public static readonly Field Archeology = new Field(nameof(Archeology), "archeology");
        public static readonly Field Architecture = new Field(nameof(Architecture), "architecture");
        public static readonly Field Art = new Field(nameof(Art), "art, aesthetics");
        public static readonly Field Astronomy = new Field(nameof(Astronomy), "astronomy");
        public static readonly Field AudioVisual = new Field(nameof(AudioVisual), "audiovisual");
        public static readonly Field Aviation = new Field(nameof(Aviation), "aviation");
        public static readonly Field Baseball = new Field(nameof(Baseball), "baseball");
        public static readonly Field Biochemistry = new Field(nameof(Biochemistry), "biochemistry");
        public static readonly Field Biology = new Field(nameof(Biology), "biology");
        public static readonly Field Botany = new Field(nameof(Botany), "botany");
        public static readonly Field Buddhism = new Field(nameof(Buddhism), "Buddhism");
        public static readonly Field Business = new Field(nameof(Business), "business");
        public static readonly Field Chemistry = new Field(nameof(Chemistry), "chemistry");
        public static readonly Field Christianity = new Field(nameof(Christianity), "Christianity");
        public static readonly Field Clothing = new Field(nameof(Clothing), "clothing");
        public static readonly Field Computing = new Field(nameof(Computing), "computing");
        public static readonly Field Crystallography = new Field(nameof(Crystallography), "crystallography");
        public static readonly Field Ecology = new Field(nameof(Ecology), "ecology");
        public static readonly Field Economics = new Field(nameof(Economics), "economics");
        public static readonly Field Electricity = new Field(nameof(Electricity), "electricity, elec. eng.");
        public static readonly Field Electronics = new Field(nameof(Electronics), "electronics");
        public static readonly Field Engineering = new Field(nameof(Engineering), "engineering");
        public static readonly Field Entomology = new Field(nameof(Entomology), "entomology");
        public static readonly Field Finance = new Field(nameof(Finance), "finance");
        public static readonly Field Fishing = new Field(nameof(Fishing), "fishing");
        public static readonly Field Food = new Field(nameof(Food), "food, cooking");
        public static readonly Field Gardening = new Field(nameof(Gardening), "gardening, horticulture");
        public static readonly Field Genetics = new Field(nameof(Genetics), "genetics");
        public static readonly Field Geography = new Field(nameof(Geography), "geography");
        public static readonly Field Geology = new Field(nameof(Geology), "geology");
        public static readonly Field Geometry = new Field(nameof(Geometry), "geometry");
        public static readonly Field Go = new Field(nameof(Go), "go (game)");
        public static readonly Field Grammar = new Field(nameof(Grammar), "grammar");
        public static readonly Field Hanafuda = new Field(nameof(Hanafuda), "hanafuda");
        public static readonly Field HorseRacing = new Field(nameof(HorseRacing), "horse racing");
        public static readonly Field Law = new Field(nameof(Law), "law");
        public static readonly Field Linguistics = new Field(nameof(Linguistics), "linguistics");
        public static readonly Field Logic = new Field(nameof(Logic), "logic");
        public static readonly Field MartialArts = new Field(nameof(MartialArts), "martial arts");
        public static readonly Field Mahjong = new Field(nameof(Mahjong), "mahjong");
        public static readonly Field Mathematics = new Field(nameof(Mathematics), "mathematics");
        public static readonly Field MechanicalEngineering = new Field(nameof(MechanicalEngineering), "mechanical engineering");
        public static readonly Field Medicine = new Field(nameof(Medicine), "medicine");
        public static readonly Field Meteorology = new Field(nameof(Meteorology), "meteorology");
        public static readonly Field Military = new Field(nameof(Military), "military");
        public static readonly Field Music = new Field(nameof(Music), "music");
        public static readonly Field Ornithology = new Field(nameof(Ornithology), "ornithology");
        public static readonly Field Paleontology = new Field(nameof(Paleontology), "paleontology");
        public static readonly Field Pharmacy = new Field(nameof(Pharmacy), "pharmacy");
        public static readonly Field Philosophy = new Field(nameof(Philosophy), "philosophy");
        public static readonly Field Photography = new Field(nameof(Photography), "photography");
        public static readonly Field Physics = new Field(nameof(Physics), "physics");
        public static readonly Field Physiology = new Field(nameof(Physiology), "physiology");
        public static readonly Field Printing = new Field(nameof(Printing), "printing");
        public static readonly Field Psychiatry = new Field(nameof(Psychiatry), "psychiatry");
        public static readonly Field Psychology = new Field(nameof(Psychology), "psychology");
        public static readonly Field Railway = new Field(nameof(Railway), "railway");
        public static readonly Field Shinto = new Field(nameof(Shinto), "Shinto");
        public static readonly Field Shogi = new Field(nameof(Shogi), "shogi");
        public static readonly Field Sports = new Field(nameof(Sports), "sports");
        public static readonly Field Statistics = new Field(nameof(Statistics), "statistics");
        public static readonly Field Sumo = new Field(nameof(Sumo), "sumo");
        public static readonly Field Telecommunications = new Field(nameof(Telecommunications), "telecommunications");
        public static readonly Field Trademark = new Field(nameof(Trademark), "trademark");
        public static readonly Field VideoGames = new Field(nameof(VideoGames), "video games");
        public static readonly Field Zoology = new Field(nameof(Zoology), "zoology");

        public string Code { get; }

        public Field(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
