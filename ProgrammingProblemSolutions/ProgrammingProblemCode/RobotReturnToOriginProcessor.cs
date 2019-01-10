namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RobotReturnToOriginProcessor
    {
        private int xPos { get; set; }
        private int yPos { get; set; }

        public bool JudgeCircle(string moveString)
        {
            char[] moves = moveString.ToCharArray();
            foreach (char move in moves)
            {
                ProcessMove(move);
            }

            return xPos == 0 && yPos == 0;
        }

        private void ProcessMove(char move)
        {
            switch (move)
            {
                case 'R':
                    xPos++;
                    break;
                case 'L':
                    xPos--;
                    break;
                case 'U':
                    yPos++;
                    break;
                case 'D':
                    yPos--;
                    break;
            }
        }
    }
}
