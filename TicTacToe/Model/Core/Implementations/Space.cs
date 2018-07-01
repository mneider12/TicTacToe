using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class Space : ISpace
    {
        public IToken Token
        {
            get
            {
                return token;
            }
            set
            {
                Debug.Assert(value != null, "Attempt to set null token");

                token = value;
                IsOccupied = true;
            }
        }

        public bool IsOccupied
        {
            get;
            private set;
        }

        private IToken token;
    }
}