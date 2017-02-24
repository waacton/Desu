namespace Wacton.Desu.Strokes
{
    using System.Collections.Generic;

    public interface IStrokeLookup
    {
        IDictionary<string, List<string>> GetKanjiToStrokes();
    }
}
