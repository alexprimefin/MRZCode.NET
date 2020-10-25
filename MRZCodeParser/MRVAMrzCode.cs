using System.Collections.Generic;
using System.Linq;

namespace MRZCodeParser
{
    internal class MRVAMrzCode : MrzCode
    {
        internal MRVAMrzCode(IEnumerable<string> lines) : base(lines)
        {
        }

        public override CodeType Type => CodeType.MRVA;

        public override IEnumerable<MrzLine> Lines => new MrzLine[]
        {
            new MRVAFirstLine(RawLines.First()),
            new MRVASecondLine(RawLines.Last())
        };
    }
}