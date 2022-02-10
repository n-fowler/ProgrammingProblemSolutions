using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MaximumWordsInSentencesProcessor
    {
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                int count = 1; //Number of words exceeds spaces by one always

                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if(sentences[i][j] == ' ')
                    {
                        count++;
                    }
                }
                
                if (count > max)
                {
                    max = count;
                }
            }

            return max;
        }
    }
}
