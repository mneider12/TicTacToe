using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;

namespace TicTacToeTest
{
    [TestClass]
    public class TokenTest
    {
        [TestMethod]
        public void teamTest()
        {
            Team team = Team.X;
            Token token = new Token(team);
            Assert.AreEqual(team, token.Team);
        }
    }
}
