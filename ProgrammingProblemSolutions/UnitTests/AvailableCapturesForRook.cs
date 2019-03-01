using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class AvailableCapturesForRook
    {
        [TestCase()]
        public void AvailableCapturesForRookTestOne()
        {
            char[][] testBoard = new[]
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'R', '.', '.', '.', 'p'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            };

            Assert.AreEqual(3, new AvailableCapturesForRookProcessor().NumRookCaptures(testBoard));
        }

        [TestCase()]
        public void AvailableCapturesForRookTestTwo()
        {
            char[][] testBoard = new[]
            {
                new[] {'.','.','.','.','.','.','.','.'},
                new[] {'.','p','p','p','p','p','.','.'},
                new[] {'.','p','p','B','p','p','.','.'},
                new[] {'.','p','B','R','B','p','.','.'},
                new[] {'.','p','p','B','p','p','.','.'},
                new[] {'.','p','p','p','p','p','.','.'},
                new[] {'.','.','.','.','.','.','.','.'},
                new[] {'.','.','.','.','.','.','.','.'}
            };

            Assert.AreEqual(0, new AvailableCapturesForRookProcessor().NumRookCaptures(testBoard));
        }

        [TestCase()]
        public void AvailableCapturesForRookTestThree()
        {
            char[][] testBoard = new[]
            {
                new[] {'.','.','.','.','.','.','.','.'},
                new[] {'.','.','.','p','.','.','.','.'},
                new[] {'.','.','.','p','.','.','.','.'},
                new[] {'p','p','.','R','.','p','B','.'},
                new[] {'.','.','.','.','.','.','.','.'},
                new[] {'.','.','.','B','.','.','.','.'},
                new[] {'.','.','.','p','.','.','.','.'},
                new[] {'.','.','.','.','.','.','.','.'}
            };

            Assert.AreEqual(3, new AvailableCapturesForRookProcessor().NumRookCaptures(testBoard));
        }
    }
}
