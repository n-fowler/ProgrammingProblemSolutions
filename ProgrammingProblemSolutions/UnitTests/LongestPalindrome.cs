using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class LongestPalindrome
    {
        [TestCase("babad", ExpectedResult = "bab")]
        [TestCase("cbbd", ExpectedResult = "bb")]
        public string LongestPalindromeTest(string palindrome)
        {
            return new LongestPalindromeProcessor().LongestPalindrome(palindrome);
        }
    }
}
