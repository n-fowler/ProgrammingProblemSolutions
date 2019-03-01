using System.Drawing;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class AvailableCapturesForRookProcessor
    {
        private char[][] ChessBoard { get; set; }
        private int PossibleCaptures { get; set; }

        public int NumRookCaptures(char[][] board)
        {
            ChessBoard = board;

            var rookPosition = GetRookPosition();
            ScanLeft(rookPosition.X, rookPosition.Y);
            ScanRight(rookPosition.X, rookPosition.Y);
            ScanDown(rookPosition.X, rookPosition.Y);
            ScanUp(rookPosition.X, rookPosition.Y);

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

        private Point GetRookPosition()
        {
            for (int i = 0; i < ChessBoard.Length; i++)
            {
                for (int j = 0; j < ChessBoard[i].Length; j++)
                {
                    if (GetPiece(ChessBoard[i][j]) == Piece.Rook)
                    {
                        return new Point(j, i);
                    }
                }
            }

            return new Point(-1, -1);
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
