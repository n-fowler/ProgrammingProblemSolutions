using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    //Runtime 88ms, faster than 91%, memory usage less than 100%
    public class UniqueNumberOfOccurrencesProcessor
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (!resultDictionary.ContainsKey(i))
                {
                    resultDictionary.Add(i, 1);
                }
                else
                {
                    resultDictionary[i] += 1;
                }
            }

            return resultDictionary.Values.Distinct().Count() >= resultDictionary.Values.Count;
        }
    }
}
