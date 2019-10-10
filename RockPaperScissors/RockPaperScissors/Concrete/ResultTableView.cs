using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Concrete
{
    public class ResultTableView
    {
        public int Round { get; set; }
        public GameObject PlayerOneObject { get; set; } //PlayerOne chooise
        public GameObject PlayerTwoObject { get; set; } //PlayerTwo chooise
        public Player WinnerPlayer { get; set; }
        public GameResult WinnerObject { get; set; }

        public ResultTableView(int round,GameObject playerOneObject,GameObject playerTwoObject)
        {
            Round = round;
            PlayerOneObject = playerOneObject;
            PlayerTwoObject = playerTwoObject;
            WinnerObject =(GameResult)Rule.GetWinnerObject(playerOneObject, playerTwoObject);

            if (WinnerObject == GameResult.Draw)
                WinnerPlayer = Player.NoOne;
            else if (WinnerObject == (GameResult)playerOneObject)
                WinnerPlayer = Player.PlayerOne;
            else
                WinnerPlayer = Player.PlayerTwo;
        }
    }
}
