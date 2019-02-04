using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class MajorityElementProblem
    {
        //Faster than 72% of submissions at the expense of memory
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else if (dict.ContainsKey(num))
                {
                    dict[num] += 1;
                }
            }

            int max = 0;
            int key = 0;

            for (int i = 0; i < dict.Values.Count; i++)
            {
                int current = dict.Values.ToList()[i];
                if (current <= max) continue;
                max = current;
                key = dict.Keys.ToList()[i];
            }

            return key;
        }
    }
}
