namespace Wacton.Desu.Names
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// A dictionary of Japanese proper names
    /// </summary>
    public interface INameDictionary
    {
        /// <summary>
        /// Returns the entries of the proper names dictionary
        /// </summary>
        IEnumerable<INameEntry> GetEntries();

        /// <summary>
        /// Returns the entries of the proper names dictionary asynchronously
        /// </summary>
        Task<IEnumerable<INameEntry>> GetEntriesAsync();
    }
}
