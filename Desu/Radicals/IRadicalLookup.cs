namespace Wacton.Desu.Radicals
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// A lookup between kanji characters and radicals
    /// </summary>
    public interface IRadicalLookup
    {
        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        IDictionary<string, IEnumerable<string>> GetKanjiToRadicals();

        /// <summary>
        /// Returns the lookup of kanji to radicals asynchronously
        /// </summary>
        Task<IDictionary<string, IEnumerable<string>>> GetKanjiToRadicalsAsync();

        /// <summary>
        /// Returns the lookup of radical to kanjis
        /// </summary>
        IDictionary<string, IEnumerable<string>> GetRadicalToKanjis();

        /// <summary>
        /// Returns the lookup of radical to kanjis asynchronously
        /// </summary>
        Task<IDictionary<string, IEnumerable<string>>> GetRadicalToKanjisAsync();
    }
}
