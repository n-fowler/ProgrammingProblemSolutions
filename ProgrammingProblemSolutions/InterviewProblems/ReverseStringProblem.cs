﻿namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class ReverseStringProblem
    {
        public void ReverseString(char[] s)
        {
            for (int i = 0; i < s.Length/2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
