namespace Wacton.Desu.Japanese
{
    public class EntryElementData
    {
        public string Content { get; }
        public string LanguageAttribute { get; }
        public string GlossGenderAttribute { get; }
        public string LoanwordTypeAttribute { get; }
        public string LoanwordWaseiAttribute { get; }

        public EntryElementData(string content, 
            string languageAttribute, string glossGenderAttribute, 
            string loanwordTypeAttribute, string loanwordWaseiAttribute)
        {
            this.Content = content;
            this.LanguageAttribute = languageAttribute;
            this.GlossGenderAttribute = glossGenderAttribute;
            this.LoanwordTypeAttribute = loanwordTypeAttribute;
            this.LoanwordWaseiAttribute = loanwordWaseiAttribute;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}
