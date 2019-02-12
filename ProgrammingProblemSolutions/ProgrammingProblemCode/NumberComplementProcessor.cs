using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class NumberComplementProcessor
    {
        //Faster than 99.07%
        public int FindComplement(int num)
        {
            int mask = (1 << (int)Math.Ceiling((Math.Log(num + 1) / Math.Log(2)))) - 1;
            return ~num & mask;
        }
    }
}
