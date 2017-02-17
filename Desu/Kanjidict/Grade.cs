namespace Wacton.Desu.Kanjidict
{
    using Wacton.Tovarisch.Enum;

    public class Grade : Enumeration
    {
        public static readonly Grade Grade1 = new Grade("Grade1", 1);
        public static readonly Grade Grade2 = new Grade("Grade2", 2);
        public static readonly Grade Grade3 = new Grade("Grade3", 3);
        public static readonly Grade Grade4 = new Grade("Grade4", 4);
        public static readonly Grade Grade5 = new Grade("Grade5", 5);
        public static readonly Grade Grade6 = new Grade("Grade6", 6);
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
