using System.Linq;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class ContainsDuplicateProblem
    {
        //Faster than 93% of submissions, thanks csharp!
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.ToList().Distinct().Count() != nums.Length;
        }
    }
}
