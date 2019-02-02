namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ImageFlipProcessor
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            foreach (int[] intArray in A)
            {
                Flip(intArray);
            }

            foreach (int[] intArray in A)
            {
                Invert(intArray);
            }

            return A;
        }

        internal void Flip(int[] intArray)
        {
            for (int index = 0; index < intArray.Length / 2; index++)
            {
                int temp = intArray[index];
                intArray[index] = intArray[intArray.Length - index - 1];
                intArray[intArray.Length - index - 1] = temp;
            }
        }

        internal void Invert(int[] intArray)
        {
            for (int index = 0; index < intArray.Length; index++)
            {
                intArray[index] = 1 - intArray[index];
            }
        }
    }
}
