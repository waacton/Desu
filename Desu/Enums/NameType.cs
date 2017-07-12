namespace Wacton.Desu.Enums
{
    public class NameType : Enumeration
    {
        public static readonly NameType Company = new NameType("Company", "company name");
        public static readonly NameType Female = new NameType("Female", "female given name or forename");
        public static readonly NameType Given = new NameType("Given", "given name or forename, gender not specified");
        public static readonly NameType Male = new NameType("Male", "male given name or forename");
        public static readonly NameType OldOrIrregular = new NameType("OldOrIrregular", "old or irregular kana form");
        public static readonly NameType Organization = new NameType("Organization", "organization name");
        public static readonly NameType Person = new NameType("Person", "full name of a particular person");
        public static readonly NameType Place = new NameType("Place", "place name");
        public static readonly NameType Product = new NameType("Product", "product name");
        public static readonly NameType Station = new NameType("Station", "railway station");
        public static readonly NameType Surname = new NameType("Surname", "family or surname");
        public static readonly NameType Unclassified = new NameType("Unclassified", "unclassified name");
        public static readonly NameType Work = new NameType("Work", "work of art, literature, music, etc. name");

        public string Code { get; }

        public NameType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
