using ProgrammingProblemSolutions.InterviewProblems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    //TODO fix edge cases
    public class LongestPalindromeProcessor
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0) return String.Empty;

            n = 2 * n + 1;

            int[]l = new int[n];
            l[0] = 0;
            l[1] = 1;

            //Center Position, Center Right Position, CurrentRightPosition
            int center = (int)Position.CenterPosition;
            int centerright = (int)Position.CenterRightPosition;
            int currentright = (int)Position.CurrentRightPosition;

            //Current Left Position
            int currentRightMirror;
            int expand = -1;
            int diff = -1;
            int maxLPSLength = 0;
            int maxLPSCenterPosition = 0;
            int start = -1;
            int end = -1;

            for (currentright = 2; currentright < n; currentright++)
            {
                currentRightMirror = 2 * center - currentright;
                expand = 0;
                diff = centerright - currentright;

                if (diff >= 0)
                {
                    if(l[currentRightMirror] < diff)
                    {
                        l[currentright] = l[currentRightMirror];
                    }
                    else if(l[currentRightMirror] == diff && centerright == n - 1)
                    {
                        l[currentright] = l[currentRightMirror];
                    }
                    else if(l[currentRightMirror] == diff && centerright < n - 1)
                    {
                        l[currentright] = l[currentRightMirror];
                        expand = 1;
                    }
                }
                else
                {
                    l[currentright] = 0;
                    expand = 1;
                }

                if(expand == 1)
                {
                    try
                    {
                        while (((currentright + l[currentright]) < n &&
                                (currentright - l[currentright]) > 0) &&
                              (((currentright + l[currentright] + 1) % 2 == 0) ||
                               (s[(currentright + l[currentright] + 1) / 2] ==
                                s[(currentright - l[currentright] - 1) / 2])))
                        {
                            l[currentright]++;
                        }
                    }
                    catch (Exception)
                    {
                        Debug.Assert(true);
                    }
                }

                if (l[currentright] > maxLPSLength)
                {
                    maxLPSLength = l[currentright];
                    maxLPSCenterPosition = currentright;
                }

                if (currentright + l[currentright] > centerright)
                {
                    center = currentright;
                    centerright = currentright + l[currentright];
                }
            }

            start = (maxLPSCenterPosition -
             maxLPSLength) / 2;
            end = start + maxLPSLength - 1;

            return s.Substring(start, end);
        }

        private enum Position
        {
            CurrentRightPosition = 0,
            CenterPosition = 1,
            CenterRightPosition = 2
        }
    }

    
}
