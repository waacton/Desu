namespace Wacton.Desu.Enums
{
    public class SkipMisclassification : Enumeration
    {
        public static readonly SkipMisclassification None = new SkipMisclassification("None", string.Empty);
        public static readonly SkipMisclassification Division = new SkipMisclassification("Division", "posn");
        public static readonly SkipMisclassification StrokeCount = new SkipMisclassification("StrokeCount", "stroke_count");
        public static readonly SkipMisclassification DivisionAndStrokeCount = new SkipMisclassification("DivisionAndStrokeCount", "stroke_and_posn");
        public static readonly SkipMisclassification AmbiguousStrokeCounts = new SkipMisclassification("AmbiguousStrokeCounts", "stroke_diff");

        public string Code { get; }

        public SkipMisclassification(string displayName, string code)
            : base(displayName)
        {
            this.Code = code;
        }
    }
}
