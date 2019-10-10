using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    //type of hand shape
    public enum GameObject
    {
        Rock,Paper,Scissors
    }
    public enum GameResult
    {
        Rock,
        Paper,
        Scissors,
        Draw //when the both players threw the same object
    }
    public enum Player
    {
        PlayerOne,
        PlayerTwo,
        NoOne //when the both players threw the same object
    }
}
