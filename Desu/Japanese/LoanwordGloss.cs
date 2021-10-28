namespace Wacton.Desu.Japanese
{
    using System;
    using System.Collections.Generic;
    using Wacton.Desu.Enums;

    internal class LoanwordGloss : Gloss, ILoanwordGloss, IEquatable<LoanwordGloss>
    {
        public bool IsPartial { get; }
		public bool IsWasei { get; }

        public LoanwordGloss(string term, Language language, GlossType type, string gender, bool isPartial = false, bool isWasei = false)
            : base(term, language, type, gender)
        {
            this.IsPartial = isPartial;
            this.IsWasei = isWasei;
        }

        /* ---------- auto-generated ---------- */

        public override bool Equals(object obj)
        {
            return Equals(obj as LoanwordGloss);
        }

        public bool Equals(LoanwordGloss other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Term == other.Term &&
                   EqualityComparer<Language>.Default.Equals(Language, other.Language) &&
                   EqualityComparer<GlossType>.Default.Equals(Type, other.Type) &&
                   Gender == other.Gender &&
                   IsPartial == other.IsPartial &&
                   IsWasei == other.IsWasei;
        }

        public override int GetHashCode()
        {
            int hashCode = -398647277;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Term);
            hashCode = hashCode * -1521134295 + EqualityComparer<Language>.Default.GetHashCode(Language);
            hashCode = hashCode * -1521134295 + EqualityComparer<GlossType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Gender);
            hashCode = hashCode * -1521134295 + IsPartial.GetHashCode();
            hashCode = hashCode * -1521134295 + IsWasei.GetHashCode();
            return hashCode;
        }
    }
}
