﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TicTacToe.Controls
{
    public class BoardTileClickEventArgs : EventArgs
    {
        public int Column { get; set; }
        public int Row { get; set; }
    }
}