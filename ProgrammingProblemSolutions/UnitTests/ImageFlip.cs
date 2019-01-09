using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class ImageFlip
    {
        [Test]
        //Input: [[1,1,0],[1,0,1],[0,0,0]]
        //Output: [[1,0,0],[0,1,0],[1,1,1]]
        public void ImageFlipTest()
        {
            int[][] inputImageFlip = { new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 } };
            int[][] expectedImageFlip = { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 1, 1, 1 } };
            Assert.AreEqual(expectedImageFlip, new ImageFlipProcessor().FlipAndInvertImage(inputImageFlip));
        }

        [Test]
        //Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
        //Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
        public void ImageFlipTest2()
        {
            int[][] inputImageFlip = { new[] { 1, 1, 0, 0 }, new[] { 1, 0, 0, 1 }, new[] { 0, 1, 1, 1 }, new[] { 1, 0, 1, 0 } };
            int[][] expectedImageFlip = { new[] { 1, 1, 0, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 0, 0, 1 }, new[] { 1, 0, 1, 0 } };
            Assert.AreEqual(expectedImageFlip, new ImageFlipProcessor().FlipAndInvertImage(inputImageFlip));
        }
    }
}
