using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;

namespace TicTacToeTest.Model
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void newGameTest()
        {
            IGame game = createGame();

            ICoordinate coordinate = new Coordinate(1, 1);

            Assert.IsFalse(game.isOccupied(coordinate));

            game.makeNextMove(coordinate);

            Assert.IsTrue(game.isOccupied(coordinate));

            game.newGame();

            Assert.IsFalse(game.isOccupied(coordinate));
        }

        [TestMethod]
        public void makeNextMoveTest()
        {
            IGame game = createGame();

            ICoordinate firstMoveCoordinate = new Coordinate(1, 1);
            ICoordinate secondMoveCoordinate = new Coordinate(2, 2);

            game.makeNextMove(firstMoveCoordinate);
            game.makeNextMove(secondMoveCoordinate);

            IToken firstMoveToken = game.getToken(firstMoveCoordinate);
            IToken secondMoveToken = game.getToken(secondMoveCoordinate);

            Assert.AreEqual(Team.X, firstMoveToken.Team);
            Assert.AreEqual(Team.O, secondMoveToken.Team);
        }

        [TestMethod]
        public void isOccupiedTest()
        {
            IGame game = createGame();
            ICoordinate coordinate = new Coordinate(1, 1);

            Assert.IsFalse(game.isOccupied(coordinate));

            game.makeNextMove(coordinate);

            Assert.IsTrue(game.isOccupied(coordinate));
        }

        [TestMethod]
        public void getTokenTest()
        {
            IGame game = createGame();
            ICoordinate coordinate = new Coordinate(1, 1);

            game.makeNextMove(coordinate);

            IToken token = game.getToken(coordinate);
            Assert.AreEqual(Team.X, token.Team);
        }

        private IGame createGame()
        {
            IBoardFactory boardFactory = new BoardFactory();
            ITokenFactory tokenFactory = new TokenFactory();
            return new Game(boardFactory, tokenFactory);
        }
    }
}
