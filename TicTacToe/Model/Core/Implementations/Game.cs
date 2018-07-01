using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToe.Model
{
    public class Game : IGame
    {
        public Game(IBoardFactory boardFactory, ITokenFactory tokenFactory)
        {
            this.boardFactory = boardFactory;
            this.tokenFactory = tokenFactory;
            newGame();
        }

        public void newGame()
        {
            board = boardFactory.create();
            nextTeamToPlay = Team.X;    //X goes first
        }

        public void makeNextMove(ICoordinate coordinate)
        {
            IToken token = tokenFactory.create(nextTeamToPlay);
            board.placeToken(token, coordinate);
            advanceToNextTurn();
        }

        public bool isOccupied(ICoordinate coordinate)
        {
            return board.isOccupied(coordinate);
        }

        public IToken getToken(ICoordinate coordinate)
        {
            return board.getToken(coordinate);
        }

        private void advanceToNextTurn()
        {
            if (nextTeamToPlay == Team.X)
            {
                nextTeamToPlay = Team.O;
            }
            else
            {
                nextTeamToPlay = Team.X;
            }
        }

        private IBoardFactory boardFactory;
        private ITokenFactory tokenFactory;

        private IBoard board;
        private Team nextTeamToPlay;
    }
}