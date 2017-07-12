namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    public interface INameDictionary
    {
        IEnumerable<INameEntry> GetEntries();
    }
}
