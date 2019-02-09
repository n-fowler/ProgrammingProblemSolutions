namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ZigZagConversionProcessor
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1)
            {
                return s;
            }

            string[] resultStrings = new string[numRows];

            int index = 0;

            while (index < s.Length)
            {
                for (int i = 0; i < numRows; i++)
                {
                    if (index < s.Length)
                    {
                        resultStrings[i] += s.Substring(index, 1);
                    }

                    index++;
                }

                for (int i = numRows - 2; i > 0; i--)
                {
                    if (index < s.Length)
                    {
                        resultStrings[i] += s.Substring(index, 1);
                    }

                    index++;
                }
            }

            return string.Join("", resultStrings);
        }
    }
}
