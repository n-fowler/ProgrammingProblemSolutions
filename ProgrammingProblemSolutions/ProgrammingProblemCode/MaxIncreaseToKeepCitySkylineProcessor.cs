namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MaxIncreaseToKeepCitySkylineProcessor
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int[] leftToRight = EvaluateLeftRight(grid);
            int[] topToBottom = EvaluateTopBottom(grid);
            int howMuchTaller = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int x = 0; x < grid.Length; x++)
                {
                    while (grid[i][x] < leftToRight[i] && grid[i][x] < topToBottom[x])
                    {
                        howMuchTaller++;
                        grid[i][x]++;
                    }
                }
            }
            return howMuchTaller;
        }

        private int[] EvaluateLeftRight(int[][] grid)
        {
            int[] leftRightArray = new int[grid.Length];
            int tempHeight = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int x = 0; x < grid.Length; x++)
                {
                    if (grid[i][x] >= tempHeight)
                    {
                        leftRightArray[i] = grid[i][x];
                        tempHeight = grid[i][x];
                    }
                }
                tempHeight = 0;
            }
            return leftRightArray;
        }

        private int[] EvaluateTopBottom(int[][] grid)
        {
            int[] topBottomArray = new int[grid.Length];
            int tempHeight = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int x = 0; x < grid.Length; x++)
                {
                    if (grid[x][i] >= tempHeight)
                    {
                        topBottomArray[i] = grid[x][i];
                        tempHeight = grid[x][i];
                    }
                }
                tempHeight = 0;
            }
            return topBottomArray;
        }
    }
}
