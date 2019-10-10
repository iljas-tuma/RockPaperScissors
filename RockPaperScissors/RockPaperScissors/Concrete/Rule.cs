using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors.Concrete
{
    public static class Rule 
    {
        //winner scenarios
        public static GameObject[] RockScissors = new GameObject[] { GameObject.Rock, GameObject.Scissors };    //Rock crushes Scrssors
        public static GameObject[] ScissorsPaper = new GameObject[] { GameObject.Scissors, GameObject.Paper };  //Scissors cuts Paper
        public static GameObject[] PaperRock = new GameObject[] { GameObject.Paper, GameObject.Rock };          //Paper covers Rock


        public static GameResult GetWinnerObject(GameObject objectOne, GameObject objectTwo)
        {
            GameResult result = GameResult.Draw;                                                    //if objectOne==objectTwo

            if(objectOne!=objectTwo)
            {
                if (RockScissors.Contains(objectOne) && RockScissors.Contains(objectTwo))           //match(Rock-Scissors, Scissors-Rock), the winner=Rock
                    result = GameResult.Rock;
                else if (ScissorsPaper.Contains(objectOne) && ScissorsPaper.Contains(objectTwo))    //match(Scissors-Paper, Paper-Scissors), the winner=Scissors
                    result = GameResult.Scissors;
                else if (PaperRock.Contains(objectOne) && PaperRock.Contains(objectTwo))            //match(Paper-Rock, Rock-Paper), the winner=Paper
                    result = GameResult.Paper;
            }
            return result;
        }
    }
}
