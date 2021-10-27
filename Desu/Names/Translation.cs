namespace Wacton.Desu.Names
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    internal class Translation : ITranslation
    {
        internal readonly List<NameType> NameTypesList = new List<NameType>();
        public IEnumerable<NameType> NameTypes => NameTypesList;

        internal readonly List<string> CrossReferencesList = new List<string>();
        public IEnumerable<string> CrossReferences => CrossReferencesList;

        internal readonly List<string> TranscriptionsList = new List<string>();
        public IEnumerable<string> Transcriptions => TranscriptionsList;

        public override string ToString() => Transcriptions.First();
    }
}
