using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    [Serializable]
    public class Board : IBoard
    {
        public Board()
        {
            board = new ISpace[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column] = new Space();
                }
            }
        }

        #region public methods
        public IToken getToken(ICoordinate coordinate)
        {
            assertCellValid(coordinate);

            ISpace space = getSpace(coordinate);
            return space.Token;
        }

        public void placeToken(IToken token, ICoordinate coordinate)
        {
            assertCellValid(coordinate);

            ISpace space = getSpace(coordinate);

            Debug.Assert(!space.IsOccupied);

            space.Token = token;
        }

        public bool isOccupied(ICoordinate coordinate)
        {
            ISpace space = getSpace(coordinate);
            return space.IsOccupied;
        }
        #endregion

        private ISpace getSpace(ICoordinate coordinate)
        {
            return board[coordinate.Row, coordinate.Column];
        }

        private ISpace[,] board;
        #region debug
        #region debug methods
        private void assertCellValid(ICoordinate coordinate)
        {
            Debug.Assert(isCellValid(coordinate), INVALID_CELL_ACCESS, ROW_COLUMN_DETAIL, coordinate.Row, coordinate.Column);
        }

        private bool isCellValid(ICoordinate coordinate)
        {
            return (isDimensionValid(coordinate.Row) && isDimensionValid(coordinate.Column));
        }

        private bool isDimensionValid(int dimension)
        {
            return dimension >= 0 && dimension <= 2;
        }
        #endregion
        #region debug strings
        private const string INVALID_CELL_ACCESS = "Invalid cell access";
        private const string ROW_COLUMN_DETAIL = "Row: {0}, Column: {1}";
        #endregion
        #endregion
    }
}