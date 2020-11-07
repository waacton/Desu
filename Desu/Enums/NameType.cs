namespace Wacton.Desu.Enums
{
    public class NameType : Enumeration
    {
        public static readonly NameType Company = new NameType(nameof(Company), "company name");
        public static readonly NameType Female = new NameType(nameof(Female), "female given name or forename");
        public static readonly NameType Given = new NameType(nameof(Given), "given name or forename, gender not specified");
        public static readonly NameType Male = new NameType(nameof(Male), "male given name or forename");
        //public static readonly NameType OldOrIrregular = new NameType(nameof(OldOrIrregular), "old or irregular kana form");
        public static readonly NameType Organization = new NameType(nameof(Organization), "organization name");
        public static readonly NameType Person = new NameType(nameof(Person), "full name of a particular person");
        public static readonly NameType Place = new NameType(nameof(Place), "place name");
        public static readonly NameType Product = new NameType(nameof(Product), "product name");
        public static readonly NameType Station = new NameType(nameof(Station), "railway station");
        public static readonly NameType Surname = new NameType(nameof(Surname), "family or surname");
        public static readonly NameType Unclassified = new NameType(nameof(Unclassified), "unclassified name");
        public static readonly NameType Work = new NameType(nameof(Work), "work of art, literature, music, etc. name");

        public string Code { get; }

        public NameType(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
