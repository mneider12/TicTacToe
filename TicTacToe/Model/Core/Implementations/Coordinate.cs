using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class Coordinate : ICoordinate
    {
        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Column
        {
            get;
            private set;
        }

        public int Row
        {
            get;
            private set;
        }
    }
}