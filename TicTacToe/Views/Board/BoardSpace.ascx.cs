using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicTacToe.Model;

namespace TicTacToe.Views
{
    public partial class BoardSpace : System.Web.UI.UserControl
    {
        public event EventHandler Selected;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_OnClick(object sender, EventArgs eventArgs)
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }
    }
}