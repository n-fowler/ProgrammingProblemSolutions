﻿using System.Collections.Generic;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class RomanToIntegerProblem
    {
        public int RomanToInt(string s)
        {
            int value = 0;
            bool performedSubtraction = false;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == chars.Length - 1)
                {
                    if (performedSubtraction)
                    {
                        return value;
                    }
                    value += GetRomanNumeralValue(chars[i]);
                    return value;
                }
                Dictionary<bool, int> dict = ShouldPerformRomanSubtraction(chars[i], chars[i + 1]);
                if (dict.ContainsKey(true))
                {
                    performedSubtraction = true;
                    value += dict.GetValueOrDefault(true);
                }
                else
                {
                    value += GetRomanNumeralValue(chars[i]);
                }
            }

            return value;
        }

        private Dictionary<bool, int> ShouldPerformRomanSubtraction(char current, char next)
        {
            Dictionary<bool, int> dict = new Dictionary<bool, int>();

            if (current == 'I' && (next == 'V' || next == 'X'))
            {
                dict.Add(true, next == 'V' ? 4 : 9);
            }
            else if (current == 'X' && (next == 'L' || next == 'C'))
            {
                dict.Add(true, next == 'L' ? 40 : 90);
            }
            else if (current == 'C' && (next == 'D' || next == 'M'))
            {
                dict.Add(true, next == 'D' ? 400 : 900);
            }
            else
            {
                dict.Add(false, 0);
            }

            return dict;
        }

        private int GetRomanNumeralValue(char c)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            return dict.GetValueOrDefault(c);
        }
    }
}
