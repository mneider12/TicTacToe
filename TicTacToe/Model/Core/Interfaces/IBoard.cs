using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface IBoard
    {
        IToken getToken(ICoordinate coordinate);
        void placeToken(IToken token, ICoordinate coordinate);
        bool isOccupied(ICoordinate coordinate);
    }
}
