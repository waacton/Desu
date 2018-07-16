namespace Wacton.Desu.Japanese
{
    using Wacton.Desu.Enums;

    public class LoanwordGloss : Gloss
    {
        public bool IsPartial { get; }
		public bool IsWasei { get; }

        public LoanwordGloss(string term, Language language, GlossType type, string gender, bool isPartial = false, bool isWasei = false)
            : base(term, language, type, gender)
        {
            this.IsPartial = isPartial;
            this.IsWasei = isWasei;
        }
    }
}
