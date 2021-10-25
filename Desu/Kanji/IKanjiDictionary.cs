namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    /// <summary>
    /// A dictionary of kanji characters
    /// </summary>
    public interface IKanjiDictionary
    {
        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        IEnumerable<IKanjiEntry> GetEntries();
    }
}
