using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToe.Model.TeamEnum;

namespace TicTacToe.Model
{
    public interface IToken
    {
        Team Team { get; }
    }
}
