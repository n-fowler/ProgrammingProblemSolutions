using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MinimumSumAfterSplittingDigitsProcessor
    {
        public int MinimumSum(int num)
        {
            string numStr = num.ToString();
            int numStrLength = numStr.Length;
            int[] digitArray = new int[numStrLength];

            for (int i = 0; i < numStrLength; i++)
            {
                digitArray[i] = numStr[i] - 48;
            }

            Array.Sort(digitArray);

            return digitArray[0]*10 + digitArray[1]*10 + digitArray[2] + digitArray[3];
        }
    }
}
