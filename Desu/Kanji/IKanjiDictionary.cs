namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// A dictionary of kanji characters
    /// </summary>
    public interface IKanjiDictionary
    {
        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        IEnumerable<IKanjiEntry> GetEntries();

        /// <summary>
        /// Returns the entries of the kanji dictionary asynchronously
        /// </summary>
        Task<IEnumerable<IKanjiEntry>> GetEntriesAsync();
    }
}
