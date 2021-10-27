using System.Collections.Generic;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests.Names
{
    public class TestReading : IReading
    {
        public string Text { get; set; }
        public IEnumerable<string> Restriction { get; set; } = new List<string>();
        public IEnumerable<ReadingInformation> Informations { get; set; } = new List<ReadingInformation>();
        public IEnumerable<Priority> Priorities { get; set; } = new List<Priority>();

        public override string ToString() => Text;
    }
}
