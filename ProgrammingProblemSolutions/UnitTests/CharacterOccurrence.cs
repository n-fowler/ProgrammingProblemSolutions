using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class CharacterOccurrence
    {
        [TestCase("word", ExpectedResult = 'd')] //any valid but d is returned first
        [TestCase("loop", ExpectedResult = 'o')]
        [TestCase("mississippi", ExpectedResult = 's')] //i also valid
        public char CharacterOccurrenceTest(string word)
        {
            return new CharacterOccurrenceProcessor().GetCharacterWithGreatestOccurences(word);
        }
    }
}
