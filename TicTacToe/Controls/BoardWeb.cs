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
    public class BoardWeb : WebControl
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
            for (int row = 0; row < 3; row++)
            {
                Controls.Add(new BoardRowWeb());
            }
        }

        protected override bool OnBubbleEvent(object source, EventArgs args)
        {
            bool handled = false;

            if (args is BoardTileClickEventArgs)
            {
                ((BoardTileClickEventArgs)args).Row = Controls.IndexOf((Control)source);
                RaiseBubbleEvent(this, args);
                handled = true;
            }

            return handled;
        }
    }
}
