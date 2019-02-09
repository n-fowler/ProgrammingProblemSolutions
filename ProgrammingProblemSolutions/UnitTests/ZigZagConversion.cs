using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ZigZagConversion
    {
        [TestCase("PAYPALISHIRING", 3, ExpectedResult = "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING", 4, ExpectedResult = "PINALSIGYAHRPI")]
        public string ZigZagConversionTest(string s, int numRows)
        {
            return new ZigZagConversionProcessor().Convert(s, numRows);
        }
    }
}
