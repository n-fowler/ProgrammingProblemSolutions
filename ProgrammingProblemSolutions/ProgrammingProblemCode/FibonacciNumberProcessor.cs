namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class FibonacciNumberProcessor
    {
        //The problem states N is less than or equal to 30
        public int Fib(int N)
        {
            int[] fibonacciNumbers = new int[31];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int n = 2; n < fibonacciNumbers.Length; n++)
            {
                fibonacciNumbers[n] = fibonacciNumbers[n - 1] + fibonacciNumbers[n - 2];
            }

            return fibonacciNumbers[N];
        }
    }
}
