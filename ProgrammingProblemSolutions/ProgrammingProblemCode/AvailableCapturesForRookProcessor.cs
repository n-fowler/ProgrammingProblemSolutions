namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class AvailableCapturesForRookProcessor
    {
        private char[][] ChessBoard { get; set; }
        private int PossibleCaptures { get; set; }

        public int NumRookCaptures(char[][] board)
        {
            ChessBoard = board;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (GetPiece(board[i][j]) != Piece.Rook)
                    {
                        continue;
                    }

                    ScanLeft(j, i);
                    ScanRight(j, i);
                    ScanDown(j, i);
                    ScanUp(j, i);
                }
            }

            return PossibleCaptures;
        }

        private enum Piece
        {
            Rook = 'R',
            Bishop = 'B',
            Pawn = 'p',
            EmptySpace = '.'
        }

        private Piece GetPiece(char c)
        {
            switch (c)
            {
                case 'R':
                    return Piece.Rook;
                case 'B':
                    return Piece.Bishop;
                case 'p':
                    return Piece.Pawn;
                default:
                    return Piece.EmptySpace;
            }
        }

        private void ScanLeft(int x, int y)
        {
            for (int i = x; i >= 0; i--)
            {
                var currentPiece = GetPiece(ChessBoard[y][i]);

                if (currentPiece == Piece.Bishop)
                {
                    return;
                }

                if (currentPiece == Piece.Pawn)
                {
                    PossibleCaptures++;
                    return;
                }
            }
        }

        private void ScanRight(int x, int y)
        {
            for (int i = x; i < ChessBoard.Length; i++)
            {
                var currentPiece = GetPiece(ChessBoard[y][i]);

                if (currentPiece == Piece.Bishop)
                {
                    return;
                }

                if (currentPiece == Piece.Pawn)
                {
                    PossibleCaptures++;
                    return;
                }
            }
        }

        private void ScanDown(int x, int y)
        {
            for (int i = y; i >= 0; i--)
            {
                var currentPiece = GetPiece(ChessBoard[i][x]);

                if (currentPiece == Piece.Bishop)
                {
                    return;
                }

                if (currentPiece == Piece.Pawn)
                {
                    PossibleCaptures++;
                    return;
                }
            }
        }

        private void ScanUp(int x, int y)
        {
            for (int i = y; i < ChessBoard.Length; i++)
            {
                var currentPiece = GetPiece(ChessBoard[i][x]);

                if (currentPiece == Piece.Bishop)
                {
                    return;
                }

                if (currentPiece == Piece.Pawn)
                {
                    PossibleCaptures++;
                    return;
                }
            }
        }
    }
}
