using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TicTacToe.Model;

namespace TicTacToe.Views
{
    public partial class Board : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (game == null)
            {
                IBoardFactory boardFactory = new BoardFactory();
                ITokenFactory tokenFactory = new TokenFactory();
                game = new Game(boardFactory, tokenFactory);

                BoardRow0.BoardSpaceSelected += OnBoardSpaceSelected;
                BoardRow1.BoardSpaceSelected += OnBoardSpaceSelected;
                BoardRow2.BoardSpaceSelected += OnBoardSpaceSelected;
            }
        }

        public void OnBoardSpaceSelected(object sender, BoardSpaceSelectedEventArgs eventArgs)
        {
            BoardRow boardRow = (BoardRow)sender;
            int row = getRow(boardRow);

            ICoordinate coordinate = new Coordinate(row, eventArgs.Column);

            game.makeNextMove(coordinate);
        }

        private int getRow(BoardRow row)
        {
            if (BoardRow0.Equals(row))
            {
                return 0;
            }
            if (BoardRow1.Equals(row))
            {
                return 1;
            }
            if (BoardRow2.Equals(row))
            {
                return 2;
            }
            throw new Exception("Invalid BoardSpace checked by getRow");
        }

        private IGame game;
    }
}