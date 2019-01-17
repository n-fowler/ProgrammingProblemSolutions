using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class FindAndReplacePatternProcessor
    {
        public string[] FindAndReplacePattern(string[] words, string pattern)
        {
            List<string> patternMatches = new List<string>();

            foreach (string word in words)
            {
                string wordPattern = GetPattern(word);
                if (wordPattern == pattern)
                {
                    patternMatches.Add(word);
                }
            }

            return patternMatches.ToArray();
        }

        private string GetPattern(string word)
        {
            char[] wordChar = word.ToCharArray();
            char[] processedChar = new char[wordChar.Length];
            char[] patternChar = new char[wordChar.Length];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int index = 0;

            for (int i = 0; i < wordChar.Length; i++)
            {
                if (i == 0)
                {
                    patternChar[index] = alphabet[index];
                    processedChar[index] = wordChar[i];
                }
                else if (processedChar.Contains(wordChar[i]))
                {
                    index++;
                    patternChar[i] = alphabet[new string(processedChar).IndexOf(wordChar[i])];
                    processedChar[index] = wordChar[i];
                }
                else if (wordChar[i] == wordChar[i - 1] && !processedChar.Contains(wordChar[i]))
                {
                    index++;
                    patternChar[i] = alphabet[index];
                    processedChar[index] = wordChar[i];
                }
            }

            return new string(patternChar);
        }
    }
}
