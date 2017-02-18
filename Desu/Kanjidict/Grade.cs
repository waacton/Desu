namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class Grade : Enumeration
    {
        public static readonly Grade None = new Grade("None", -1);
        public static readonly Grade One = new Grade("One", 1);
        public static readonly Grade Two = new Grade("Two", 2);
        public static readonly Grade Three = new Grade("Three", 3);
        public static readonly Grade Four = new Grade("Four", 4);
        public static readonly Grade Five = new Grade("Five", 5);
        public static readonly Grade Six = new Grade("Six", 6);
        public static readonly Grade Secondary = new Grade("Secondary", 8);
        public static readonly Grade Jinmeiyou = new Grade("Jinmeiyou", 9);
        public static readonly Grade JinmeiyouTraditional = new Grade("JinmeiyouTraditional", 10);

        public int Number { get; }

        public Grade(string displayName, int number)
            : base(displayName)
        {
            this.Number = number;
        }
    }
}
