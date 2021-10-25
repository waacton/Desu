namespace Wacton.Desu.Enums
{
    // for details see https://www.edrdg.org/wiki/index.php/KANJIDIC_Project#Content_.26_Format (misc)
    public class Grade : Enumeration
    {
        public static readonly Grade None = new Grade(nameof(None), -1);
        public static readonly Grade One = new Grade(nameof(One), 1);
        public static readonly Grade Two = new Grade(nameof(Two), 2);
        public static readonly Grade Three = new Grade(nameof(Three), 3);
        public static readonly Grade Four = new Grade(nameof(Four), 4);
        public static readonly Grade Five = new Grade(nameof(Five), 5);
        public static readonly Grade Six = new Grade(nameof(Six), 6);
        public static readonly Grade Secondary = new Grade(nameof(Secondary), 8);
        public static readonly Grade Jinmeiyou = new Grade(nameof(Jinmeiyou), 9);
        public static readonly Grade JinmeiyouTraditional = new Grade(nameof(JinmeiyouTraditional), 10);

        public int Number { get; }

        public Grade(string displayName, int number)
            : base(displayName)
        {
            this.Number = number;
        }
    }
}
