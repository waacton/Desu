namespace Wacton.Desu.Radicals
{
    using System.Collections.Generic;

    public interface IRadicalLookup
    {
        IDictionary<string, List<string>> GetKanjiToRadicals();

        IDictionary<string, List<string>> GetRadicalToKanjis();
    }
}
