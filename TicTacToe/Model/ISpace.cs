﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public interface ISpace
    {
        bool IsOccupied { get; }
        IToken Token { get; set; }
    }
}