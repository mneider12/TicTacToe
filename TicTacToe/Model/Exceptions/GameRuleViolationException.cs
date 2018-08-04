using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class GameRuleViolationException : Exception
    {
        public GameRuleViolationException(string message) : base(message) { }
    }
}