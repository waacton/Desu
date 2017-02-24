namespace Wacton.Desu.Radicals
{
    using System.Collections.Generic;

    public interface IRadicalLookup
    {
        Dictionary<string, List<string>> GetKanjiToRadicals();

        Dictionary<string, List<string>> GetRadicalToKanjis();
    }
}
