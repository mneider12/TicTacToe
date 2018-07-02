using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe.Views
{
    public partial class BoardRow : UserControl
    {
        public event EventHandler<BoardSpaceSelectedEventArgs> BoardSpaceSelected;

        protected void Page_Load(object sender, EventArgs e)
        {
            BoardSpace0.Selected += OnBoardSpaceSelected;
            BoardSpace1.Selected += OnBoardSpaceSelected;
            BoardSpace2.Selected += OnBoardSpaceSelected;
        }

        public void OnBoardSpaceSelected(object sender, EventArgs eventArgs)
        {
            BoardSpace space = (BoardSpace)sender;
            int column = getColumn(space);
            BoardSpaceSelectedEventArgs boardSpaceSelectedEventArgs = new BoardSpaceSelectedEventArgs(column);
            
            BoardSpaceSelected?.Invoke(sender, boardSpaceSelectedEventArgs);
        }

        private int getColumn(BoardSpace space)
        {
            if (BoardSpace0.Equals(space))
            {
                return 0;
            }
            if (BoardSpace1.Equals(space))
            {
                return 1;
            }
            if (BoardSpace2.Equals(space))
            {
                return 2;
            }
            throw new Exception("Invalid BoardSpace checked by getColumn");
        }
    }
}