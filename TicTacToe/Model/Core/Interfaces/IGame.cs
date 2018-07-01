using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IGame
    {
        void newGame();
        void makeNextMove(ICoordinate coordinate);
        bool isOccupied(ICoordinate coordinate);
        IToken getToken(ICoordinate coordinate);
    }
}
