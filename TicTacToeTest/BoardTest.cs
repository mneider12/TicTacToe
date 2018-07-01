using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;
using static TicTacToe.Model.TeamEnum;

namespace TicTacToeTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void getTokenTest()
        {
            IBoard board = new Board();
            ICoordinate firstMoveCoordinate = new Coordinate(0, 0);
            ICoordinate secondMoveCoordinate = new Coordinate(1, 2);
            IToken firstMoveToken = new Token(Team.X);
            IToken secondMoveToken = new Token(Team.O);

            Assert.IsNull(board.getToken(firstMoveCoordinate));
            Assert.IsNull(board.getToken(secondMoveCoordinate));

            board.placeToken(firstMoveToken, firstMoveCoordinate);
            board.placeToken(secondMoveToken, secondMoveCoordinate);

            Assert.AreEqual(firstMoveToken, board.getToken(firstMoveCoordinate));
            Assert.AreEqual(secondMoveToken, board.getToken(secondMoveCoordinate));
        }
    }
}
