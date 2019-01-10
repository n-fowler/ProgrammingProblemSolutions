using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System.Linq;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class TinyUrl
    {
        [TestCase]
        public void TinyUrlEncodeTest()
        {
            TinyUrlProcessor tiny = new TinyUrlProcessor();
            string longUrl = "https://leetcode.com/problems/design-tinyurl";
            string shortUrl = tiny.Encode(longUrl);
            string[] tinyParts = shortUrl.Split('/');
            string tinyPart = tinyParts.Last();
            Assert.AreEqual(6, tinyPart.Length);
            Assert.AreEqual(longUrl, tiny.Decode(shortUrl));
        }
    }
}
