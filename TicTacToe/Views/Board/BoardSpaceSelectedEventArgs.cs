using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicTacToe.Model;

namespace TicTacToe.Views
{
    public class BoardSpaceSelectedEventArgs : EventArgs
    {
        public BoardSpaceSelectedEventArgs(int column)
        {
            Column = column;
        }

        public int Column { get; private set; }
    }
}