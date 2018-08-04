using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    [Serializable]
    public class Token : IToken
    {
        public Token(Team team)
        {
            Team = team;
        }

        public Team Team
        {
            get;
            private set;
        }
    }
}