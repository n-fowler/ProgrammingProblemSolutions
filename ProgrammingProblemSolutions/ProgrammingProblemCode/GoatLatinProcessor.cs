using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class GoatLatinProcessor
    {
        public string ToGoatLatin(string S)
        {
            string[] words = S.Split(' ');
            for (int index = 0; index < words.Length; index++)
            {
                if (!StartsWithVowel(words[index]))
                {
                    string firstLetter = words[index].Substring(0, 1);
                    words[index] = words[index].Remove(0, 1);
                    words[index] = words[index] + firstLetter;
                }

                words[index] = words[index] + "ma" + new string('a', index + 1);
            }

            return string.Join(' ', words);
        }

        private bool StartsWithVowel(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Contains(word.ToCharArray()[0]);
        }
    }
}
