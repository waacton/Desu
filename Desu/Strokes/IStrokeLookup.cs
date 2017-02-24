namespace Wacton.Desu.Strokes
{
    using System.Collections.Generic;

    public interface IStrokeLookup
    {
        Dictionary<string, List<string>> GetKanjiToStrokes();
    }
}
