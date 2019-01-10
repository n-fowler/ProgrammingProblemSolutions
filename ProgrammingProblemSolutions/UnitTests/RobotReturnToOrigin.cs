using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class RobotReturnToOrigin
    {
        [TestCase("UD", ExpectedResult = true)]
        [TestCase("LL", ExpectedResult = false)]
        public bool RobotReturnToOriginTest(string moves)
        {
            return new RobotReturnToOriginProcessor().JudgeCircle(moves);
        }
    }
}
