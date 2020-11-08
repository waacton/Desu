using System.Collections.Generic;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests.Names
{
    public class TestKanji : IKanji
    {
        public string Text { get; set; }
        public IEnumerable<KanjiInformation> Informations { get; set; } = new List<KanjiInformation>();
        public IEnumerable<Priority> Priorities { get; set; } = new List<Priority>();

        public override string ToString()
        {
            return this.Text;
        }
    }
}
