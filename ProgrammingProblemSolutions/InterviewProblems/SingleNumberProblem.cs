namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class SingleNumberProblem
    {
        public int SingleNumber(int[] nums)
        {
            int answer = 0;
            foreach (int num in nums)
            {
                answer ^= num;
            }

            return answer;
        }
    }
}
