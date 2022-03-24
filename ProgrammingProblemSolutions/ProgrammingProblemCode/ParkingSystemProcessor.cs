using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ParkingSystemProcessor
    {
        private int[] sizes = {0,0,0,0};

        public ParkingSystemProcessor(int big, int medium, int small)
        {
            sizes[0] = 0;
            sizes[1] = big;
            sizes[2] = medium;
            sizes[3] = small;
        }

        public bool AddCar(int carType)
        {
            if(sizes[carType] > 0)
            {
                sizes[carType]--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
