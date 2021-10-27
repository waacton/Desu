namespace Wacton.Desu.Strokes
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// A lookup of kanji characters to strokes
    /// </summary>
    public interface IStrokeLookup
    {
        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        IDictionary<string, IEnumerable<string>> GetKanjiToStrokes();

        /// <summary>
        /// Returns the lookup of kanji to strokes asynchronously
        /// </summary>
        Task<IDictionary<string, IEnumerable<string>>> GetKanjiToStrokesAsync();
    }
}
