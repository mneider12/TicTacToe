using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;

namespace TicTacToeTest
{
    [TestClass]
    public class SpaceTest
    {
        [TestMethod]
        public void tokenTest()
        {
            ISpace space = new Space();
            IToken token = new Token(Team.X);

            Assert.IsNull(space.Token);

            space.Token = token;
            Assert.AreEqual(token, space.Token);
        }

        [TestMethod]
        public void isOccupiedTest()
        {
            ISpace space = new Space();
            IToken token = new Token(Team.X);

            Assert.IsFalse(space.IsOccupied);

            space.Token = token;
            Assert.IsTrue(space.IsOccupied);
        }
    }
}
