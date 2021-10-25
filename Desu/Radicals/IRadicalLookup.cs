namespace Wacton.Desu.Radicals
{
    using System.Collections.Generic;

    /// <summary>
    /// A lookup between kanji characters and radicals
    /// </summary>
    public interface IRadicalLookup
    {
        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        IDictionary<string, List<string>> GetKanjiToRadicals();

        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        IDictionary<string, List<string>> GetRadicalToKanjis();
    }
}
