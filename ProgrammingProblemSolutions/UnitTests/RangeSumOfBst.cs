using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using ProgrammingProblemSolutions.Utility;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class RangeSumOfBst
    {
        [TestCase()]
        public void RangeSumOfBstTest()
        {
            TreeNode<int?[]> root = new TreeNode<int?[]>(new int?[] { 10, 5, 15, 3, 7, null, 18 });
            RangeSumOfBstProcessor rangeSumProc = new RangeSumOfBstProcessor();
        }
    }
}
