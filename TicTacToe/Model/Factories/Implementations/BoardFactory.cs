using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class BoardFactory : IBoardFactory
    {
        public IBoard create()
        {
            return new Board();
        }
    }
}