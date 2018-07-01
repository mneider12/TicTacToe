using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class TokenFactory : ITokenFactory
    {
        public IToken create(Team team)
        {
            return new Token(team);
        }
    }
}