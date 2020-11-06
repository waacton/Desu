namespace Wacton.Desu.Enums
{
    public class Field : Enumeration
    {
        //public static readonly Field Agriculture = new Field("Agriculture", "agriculture");
        public static readonly Field Anatomy = new Field("Anatomy", "anatomy");
        //public static readonly Field Archeology = new Field("Archeology", "archeology");
        public static readonly Field Architecture = new Field("Architecture, building", "architecture, building");
        //public static readonly Field Art = new Field("Art", "art, aesthetics");
        public static readonly Field Astronomy = new Field("Astronomy", "astronomy");
        //public static readonly Field AudioVisual = new Field("AudioVisual", "audio-visual");
        //public static readonly Field Aviation = new Field("Aviation", "aviation");
        public static readonly Field Baseball = new Field("Baseball", "baseball");
        public static readonly Field Biochemistry = new Field("Biochemistry", "biochemistry");
        public static readonly Field Biology = new Field("Biology", "biology");
        public static readonly Field Botany = new Field("Botany", "botany");
        public static readonly Field Buddhism = new Field("Buddhism", "Buddhism");
        public static readonly Field Business = new Field("Business", "business");
        public static readonly Field Chemistry = new Field("Chemistry", "chemistry");
        public static readonly Field Christianity = new Field("Christianity", "Christianity");
        //public static readonly Field Climate = new Field("Climate", "climate, weather");
        public static readonly Field Computing = new Field("Computing", "computing");
        //public static readonly Field Crystallography = new Field("Crystallography", "crystallography");
        //public static readonly Field Ecology = new Field("Ecology", "ecology");
        public static readonly Field Economics = new Field("Economics", "economics");
        //public static readonly Field Electricity = new Field("Electricity", "electricity, elec. eng.");
        //public static readonly Field Electronics = new Field("Electronics", "electronics");
        //public static readonly Field Embryology = new Field("Embryology", "embryology");
        public static readonly Field Engineering = new Field("Engineering", "engineering");
        public static readonly Field Entomology = new Field("Entomology", "entomology");
        public static readonly Field Finance = new Field("Finance", "finance");
        //public static readonly Field Fishing = new Field("Fishing", "fishing");
        public static readonly Field Food = new Field("Food", "food, cooking");
        //public static readonly Field Gardening = new Field("Gardening", "gardening, horticulture");
        //public static readonly Field Genetics = new Field("Genetics", "genetics");
        //public static readonly Field Geography = new Field("Geography", "geography");
        public static readonly Field Geology = new Field("Geology", "geology");
        public static readonly Field Geometry = new Field("Geometry", "geometry");
        //public static readonly Field Go = new Field("Go", "go (game)");
        //public static readonly Field Golf = new Field("Golf", "golf");
        public static readonly Field Grammar = new Field("Grammar", "grammar");
        //public static readonly Field GreekMythology = new Field("GreekMythology", "Greek mythology");
        public static readonly Field Hanafuda = new Field("Hanafuda", "hanafuda");
        //public static readonly Field HorseRacing = new Field("HorseRacing", "horse-racing");
        public static readonly Field Law = new Field("Law", "law");
        public static readonly Field Linguistics = new Field("Linguistics", "linguistics");
        //public static readonly Field Logic = new Field("Logic", "logic");
        public static readonly Field MartialArts = new Field("MartialArts", "martial arts");
        public static readonly Field Mahjong = new Field("Mahjong", "mahjong");
        public static readonly Field Mathematics = new Field("Mathematics", "mathematics");
        //public static readonly Field MechanicalEngineering = new Field("MechanicalEngineering", "mechanical engineering");
        public static readonly Field Medicine = new Field("Medicine", "medicine");
        public static readonly Field Military = new Field("Military", "military");
        public static readonly Field Music = new Field("Music", "music");
        //public static readonly Field Ornithology = new Field("Ornithology", "ornithology");
        //public static readonly Field Paleontology = new Field("Paleontology", "paleontology");
        //public static readonly Field Pathology = new Field("Pathology", "pathology");
        //public static readonly Field Pharmacy = new Field("Pharmacy", "pharmacy");
        public static readonly Field Philosophy = new Field("Philosophy", "philosophy");
        //public static readonly Field Photography = new Field("Photography", "photography");
        public static readonly Field Physics = new Field("Physics", "physics");
        //public static readonly Field Physiology = new Field("Physiology", "physiology");
        //public static readonly Field Printing = new Field("Printing", "printing");
        //public static readonly Field Psychology = new Field("Psychology", "psychology, psychiatry");
        public static readonly Field Shinto = new Field("Shinto", "Shinto");
        public static readonly Field Shogi = new Field("Shogi", "shogi");
        public static readonly Field Sports = new Field("Sports", "sports");
        //public static readonly Field Statistics = new Field("Statistics", "statistics");
        public static readonly Field Sumo = new Field("Sumo", "sumo");
        //public static readonly Field Telecommunications = new Field("Telecommunications", "telecommunications");
        public static readonly Field Trademark = new Field("Trademark", "trademark");
        //public static readonly Field VideoGame = new Field("VideoGame", "video game");
        public static readonly Field Zoology = new Field("Zoology", "zoology");

        public string Code { get; }

        public Field(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
