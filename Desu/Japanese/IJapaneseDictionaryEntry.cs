namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    public interface IJapaneseDictionaryEntry
    {
        int Sequence { get; }
        IEnumerable<IKanji> Kanjis { get; }
        IEnumerable<IReading> Readings { get; }
        IEnumerable<ISense> Senses { get; }
    }
}
