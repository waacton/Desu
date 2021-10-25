namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    /// <summary>
    /// A dictionary of Japanese proper names
    /// </summary>
    public interface INameDictionary
    {
        /// <summary>
        /// Returns the entries of the proper names dictionary
        /// </summary>
        IEnumerable<INameEntry> GetEntries();
    }
}
