using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class KeyboardRowProcessor
    {
        public string[] FindWords(string[] words)
        {
            List<string> resultWords = new List<string>();

            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();

                if (IsTopRowWord(lowerCaseWord) || isMiddleRowWord(lowerCaseWord) || isBottomRowWord(lowerCaseWord))
                {
                    resultWords.Add(word);
                }
            }

            return resultWords.ToArray();
        }

        private bool IsTopRowWord(string word)
        {
            char[] topRowCharacters = "qwertyuiop".ToCharArray();
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (!topRowCharacters.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        private bool isMiddleRowWord(string word)
        {
            char[] middleRowCharacters = "asdfghjkl".ToCharArray();
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (!middleRowCharacters.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        private bool isBottomRowWord(string word)
        {
            char[] bottomRowCharacters = "zxcvbnm".ToCharArray();
            char[] chars = word.ToCharArray();
            foreach (char c in chars)
            {
                if (!bottomRowCharacters.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
