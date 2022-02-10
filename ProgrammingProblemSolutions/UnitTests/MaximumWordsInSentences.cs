using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MaximumWordsInSentences
    {
        [TestCase(ExpectedResult = 6)]
        public int MaximumWordsInSentencesOne()
        {
            string[] input = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            return new MaximumWordsInSentencesProcessor().MostWordsFound(input);
        }

        [TestCase(ExpectedResult = 3)]
        public int MaximumwordsInSentencesTwo()
        {
            string[] input = { "please wait", "continue to fight", "continue to win" };
            return new MaximumWordsInSentencesProcessor().MostWordsFound(input);
        }
    }
}
