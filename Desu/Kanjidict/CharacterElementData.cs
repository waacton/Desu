namespace Wacton.Desu.Kanjidict
{
    public class CharacterElementData
    {
        public string Content { get; }
        public string LanguageAttribute { get; }
        //public string GlossGenderAttribute { get; }
        //public string LoanwordTypeAttribute { get; }
        //public string LoanwordWaseiAttribute { get; }

        public CharacterElementData(string content, string languageAttribute)
        {
            this.Content = content;
            this.LanguageAttribute = languageAttribute;
            //this.GlossGenderAttribute = glossGenderAttribute;
            //this.LoanwordTypeAttribute = loanwordTypeAttribute;
            //this.LoanwordWaseiAttribute = loanwordWaseiAttribute;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
