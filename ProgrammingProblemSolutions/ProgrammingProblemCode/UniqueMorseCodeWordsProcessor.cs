using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class UniqueMorseCodeWordsProcessor
    {
        public int GetUniqueTransformations(string[] strArray)
        {
            if (strArray.Length == 0)
            {
                return 0;
            }

            List<string> transformations = new List<string>();

            foreach (string s in strArray)
            {
                char[] charArray = s.ToCharArray();
                string transformation = string.Empty;

                foreach (char c in charArray)
                {
                    transformation = transformation + GetTransformationPart(c);
                }

                transformations.Add(transformation);
            }

            return transformations.Distinct().Count();
        }

        private string GetTransformationPart(char c)
        {
            string[] transformations =
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            char[] alphabet =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (c == alphabet[i])
                {
                    return transformations[i];
                }
            }

            throw new Exception("Invalid character supplied.");
        }
    }
}
