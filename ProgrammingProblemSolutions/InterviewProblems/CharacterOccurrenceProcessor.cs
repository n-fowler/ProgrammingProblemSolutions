using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class CharacterOccurrenceProcessor
    {
        public char GetCharacterWithGreatestOccurences(string word)
        {
            Dictionary<char, int> resultDictionary = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (!resultDictionary.ContainsKey(c))
                {
                    resultDictionary.Add(c, 1);
                }
                else
                {
                    resultDictionary[c] += 1;
                }
            }

            return resultDictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
    }
}
