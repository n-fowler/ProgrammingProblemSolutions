using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class FinalValueAfterPerformingOperationsProcessor
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if(operations[i] == "++X" || operations[i] == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }

            return x;
        }
    }
}
