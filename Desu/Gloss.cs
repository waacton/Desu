namespace Wacton.Desu
{
    public class Gloss
    {
        public string Term { get; }
        public Language Language { get; }

        /// <summary> This property appears to be unused (JMdict 1.08) </summary>
        public string Gender { get; }

        public Gloss(string term, Language language, string gender)
        {
            this.Term = term;
            this.Language = language;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"{this.Language}: {this.Term}";
        }
    }
}
