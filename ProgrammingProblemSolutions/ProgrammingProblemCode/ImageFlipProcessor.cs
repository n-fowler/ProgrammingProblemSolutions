namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ImageFlipProcessor
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] B = new int[A.Length][];

            //Flip
            for (int i = 0; i < A.Length; i++)
            {
                int k = 0;
                for (int j = A[i].Length - 1; j >= 0; j--)
                {
                    B[i][k] = A[i][j];
                    k++;
                }
            }

            //Invert
            foreach (int[] b in B)
            {
                for (int k = 0; k < b.Length; k++)
                {
                    switch (b[k])
                    {
                        case 0:
                            b[k] = 1;
                            break;
                        case 1:
                            b[k] = 0;
                            break;
                    }
                }
            }

            return A;
        }
    }
}
