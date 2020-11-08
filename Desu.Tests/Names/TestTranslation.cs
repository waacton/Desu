using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests.Names
{
    public class TestTranslation : ITranslation
    {
        public IEnumerable<NameType> NameTypes { get; set; } = new List<NameType>();
        public IEnumerable<string> CrossReferences { get; set; } = new List<string>();
        public IEnumerable<string> Transcriptions { get; set; } = new List<string>();

        public override string ToString()
        {
            return this.Transcriptions.First();
        }
    }
}
