namespace Wacton.Desu.Enums
{
    public class Field : Enumeration
    {
        public static readonly Field Anatomical = new Field("Anatomical", "anatomical term");
        public static readonly Field Architecture = new Field("Architecture", "architecture term");
        public static readonly Field Astronomy = new Field("Astronomy", "astronomy, etc. term");
        public static readonly Field Baseball = new Field("Baseball", "baseball term");
        public static readonly Field Biology = new Field("Biology", "biology term");
        public static readonly Field Botany = new Field("Botany", "botany term");
        public static readonly Field Buddhist = new Field("Buddhist", "Buddhist term");
        public static readonly Field Business = new Field("Business", "business term");
        public static readonly Field Chemistry = new Field("Chemistry", "chemistry term");
        public static readonly Field Computer = new Field("Computer", "computer terminology");
        public static readonly Field Economics = new Field("Economics", "economics term");
        public static readonly Field Engineering = new Field("Engineering", "engineering term");
        public static readonly Field Finance = new Field("Finance", "finance term");
        public static readonly Field Food = new Field("Food", "food term");
        public static readonly Field Geology = new Field("Geology", "geology, etc. term");
        public static readonly Field Geometry = new Field("Geometry", "geometry term");
        public static readonly Field Law = new Field("Law", "law, etc. term");
        public static readonly Field Linguistics = new Field("Linguistics", "linguistics terminology");
        public static readonly Field Mahjong = new Field("Mahjong", "mahjong term");
        public static readonly Field MartialArts = new Field("MartialArts", "martial arts term");
        public static readonly Field Mathematics = new Field("Mathematics", "mathematics");
        public static readonly Field Medicine = new Field("Medicine", "medicine, etc. term");
        public static readonly Field Military = new Field("Military", "military");
        public static readonly Field Music = new Field("Music", "music term");
        public static readonly Field Physics = new Field("Physics", "physics terminology");
        public static readonly Field Shinto = new Field("Shinto", "Shinto term");
        public static readonly Field Shogi = new Field("Shogi", "shogi term");
        public static readonly Field Sports = new Field("Sports", "sports term");
        public static readonly Field Sumo = new Field("Sumo", "sumo term");
        public static readonly Field Zoology = new Field("Zoology", "zoology term");

        public string Code { get; }

        public Field(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
