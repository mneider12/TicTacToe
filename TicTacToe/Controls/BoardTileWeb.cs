using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicTacToe.Model;

namespace TicTacToe.Controls
{
    public class BoardTileWeb : Button
    {
        public BoardTileWeb()
        {
            CssClass = "BoardTile";
        }

        protected override void OnClick(EventArgs e)
        {
            BoardTileClickEventArgs args = new BoardTileClickEventArgs();
            RaiseBubbleEvent(this, args);
        }
    }
}
