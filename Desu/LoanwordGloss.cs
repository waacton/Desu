namespace Wacton.Desu
{
    public class LoanwordGloss : Gloss
    {
        public bool IsPartial { get; }
		public bool IsWasei { get; }

        public LoanwordGloss(string term, Language language, string gender, bool isPartial = false, bool isWasei = false)
            : base(term, language, gender)
        {
            this.IsPartial = isPartial;
            this.IsWasei = isWasei;
        }
    }
}
