using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicTacToe.Model;

namespace TicTacToe.Controls
{
    public class TicTacToeGame : WebControl
    {
        public TicTacToeGame()
        {
            BoardFactory boardFactory = new BoardFactory();
            TokenFactory tokenFactory = new TokenFactory();
            Game = new Game(boardFactory, tokenFactory);
        }

        public Game Game
        {
            get
            {
                return (Game)ViewState["Game"];
            }
            set
            {
                ViewState["Game"] = value;
            }
        }

        protected override void CreateChildControls()
        {

        }
    }
}