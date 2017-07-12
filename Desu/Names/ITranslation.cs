namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface ITranslation
    {
        IEnumerable<NameType> NameTypes { get; }
        IEnumerable<string> CrossReferences { get; }
        IEnumerable<string> Transcriptions { get; }
    }
}
