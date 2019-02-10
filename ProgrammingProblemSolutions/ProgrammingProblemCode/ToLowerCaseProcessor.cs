namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ToLowerCaseProcessor
    {
        //Faster than 95.89%
        public string ToLowerCase(string str)
        {
            string result = string.Empty;
            foreach (char c in str)
            {
                if (c >= 65 && c <= 90)
                {
                    result += (char)(c + 32);
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
