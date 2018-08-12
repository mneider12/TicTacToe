using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicTacToe.Model;

namespace TicTacToe.Controls
{
    public class BoardRowWeb : WebControl
    {
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }

        protected override void CreateChildControls()
        {
            for (int column = 0; column < 3; column++)
            {
                Controls.Add(new BoardTileWeb());
            }
        }

        protected override bool OnBubbleEvent(object source, EventArgs args)
        {
            bool handled = false;

            if (args is BoardTileClickEventArgs)
            {
                ((BoardTileClickEventArgs)args).Column = Controls.IndexOf((Control)source);
                RaiseBubbleEvent(this, args);
            }

            return handled;
        }
    }
}
