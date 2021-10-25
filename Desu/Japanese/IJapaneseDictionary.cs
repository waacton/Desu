namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    /// <summary>
    /// A dictionary of Japanese words and phrases
    /// </summary>
    public interface IJapaneseDictionary
    {
        /// <summary>
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        IEnumerable<IJapaneseEntry> GetEntries();
    }
}
