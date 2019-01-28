namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class MoveZeroesProblem
    {
        public void MoveZeroes(int[] nums)
        {
            for (int lastNonZero = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    Swap(ref nums[lastNonZero++], ref nums[i]);
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
