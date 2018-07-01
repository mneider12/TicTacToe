using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Model;

namespace TicTacToeTest.Model.Core.Implementations
{
    [TestClass]
    public class CoordinateTest
    {
        [TestMethod]
        public void columnRowTest()
        {
            int row = 2;
            int column = 3;
            ICoordinate coordinate = new Coordinate(row, column);

            Assert.AreEqual(row, coordinate.Row);
            Assert.AreEqual(column, coordinate.Column);
        }
    }
}
