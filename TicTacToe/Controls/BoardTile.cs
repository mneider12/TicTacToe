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
    public class BoardTile : Button
    {

        public BoardTile() : base()
        {
            tokenFactory = new TokenFactory();
            CssClass = "BoardTile";
        }

        private IToken Token
        {
            get
            {
                return (IToken)ViewState["Token"];
            }
            set
            {
                ViewState["Token"] = value;
                if (value != null)
                {
                    Enabled = false;
                    if (value.Team == Model.Team.X)
                    {
                        CssClass += " TeamX";
                    }
                    else
                    {
                        CssClass += " TeamO";
                    }
                }
            }
        }

        public string Team
        {
            set
            {
                Team team;
                if (Enum.TryParse<Team>(value, out team))
                {
                    Token = tokenFactory.create(team);
                }
            }
        }

        private ITokenFactory tokenFactory;
    }
}
