namespace Wacton.Desu.Names
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    public class Translation : ITranslation
    {
        private readonly List<NameType> nameTypes = new List<NameType>();
        public List<NameType> GetNameTypes() => this.nameTypes;
        public IEnumerable<NameType> NameTypes => this.GetNameTypes();

        private readonly List<string> crossReferences = new List<string>();
        public List<string> GetCrossReferences() => this.crossReferences;
        public IEnumerable<string> CrossReferences => this.GetCrossReferences();

        private readonly List<string> transcriptions = new List<string>();
        public List<string> GetTranscriptions() => this.transcriptions;
        public IEnumerable<string> Transcriptions => this.GetTranscriptions();

        public override string ToString()
        {
            return this.Transcriptions.First();
        }
    }
}
