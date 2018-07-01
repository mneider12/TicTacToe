using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;
using static TicTacToe.Model.TeamEnum;

namespace TicTacToeTest
{
    [TestClass]
    public class TokenTest
    {
        [TestMethod]
        public void TeamTest()
        {
            Team team = Team.X;
            Token token = new Token(team);
            Assert.AreEqual(team, token.Team);
        }
    }
}
