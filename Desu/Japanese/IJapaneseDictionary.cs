namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    public interface IJapaneseDictionary
    {
        IEnumerable<IJapaneseDictionaryEntry> GetEntries();
    }
}
