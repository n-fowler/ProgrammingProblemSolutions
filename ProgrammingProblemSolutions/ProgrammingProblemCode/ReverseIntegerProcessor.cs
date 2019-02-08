using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ReverseIntegerProcessor
    {
        public int Reverse(int x)
        {
            bool isNegative = false;
            if (x < 0)
            {
                x *= -1;
                isNegative = true;
            }

            IEnumerable<char> chars = x.ToString().ToCharArray().Reverse();
            char[] resultChars = new char[chars.Count()];

            for (int i = 0; i < chars.Count(); i++)
            {
                resultChars[i] = chars.ToArray()[i];
            }

            string resultString = new string(resultChars);

            try
            {
                if (isNegative)
                {
                    return -1 * Convert.ToInt32(resultString);
                }
                return Convert.ToInt32(resultString);
            }
            catch (Exception)
            {
                //Eat the exception
                return 0;
            }
        }
    }
}
