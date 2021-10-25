namespace Wacton.Desu.Strokes
{
    using System.Collections.Generic;

    /// <summary>
    /// A lookup of kanji characters to strokes
    /// </summary>
    public interface IStrokeLookup
    {
        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        IDictionary<string, List<string>> GetKanjiToStrokes();
    }
}
