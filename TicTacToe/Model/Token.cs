using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static TicTacToe.Model.TeamEnum;

namespace TicTacToe.Model
{
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