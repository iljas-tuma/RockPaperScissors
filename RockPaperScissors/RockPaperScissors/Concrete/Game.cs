using ConsoleTables;
using RockPaperScissors.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Concrete
{
    public class Game: IGame
    {
        List<ResultTableView> GameResults;
        int PlayerOnePoints=0, PlayerTwoPoints=0,RockieMistakes=0,RoundsNumber=100;
        ConsoleTable table;

        public Game()
        {
            GameResults = new List<ResultTableView>();
            table = new ConsoleTable("Round", "Player One", "Player Two", "Strongest Object", "Winner Player");
        }
        public void Play()
        {
            Random rnd = new Random(); 
            for(int i=1;i<=RoundsNumber;i++)
            {
                GameResults.Add(new ResultTableView(i, GameObject.Rock, (GameObject)rnd.Next(0, 3)));
            }
        }

        public void ShowResults()
        {
            foreach (var item in GameResults)
            {
                PlayerOnePoints += (item.WinnerObject == (GameResult)item.PlayerOneObject) ? 1 : 0;
                PlayerTwoPoints += (item.WinnerObject == (GameResult)item.PlayerTwoObject) ? 1 : 0;
                RockieMistakes  += (item.WinnerObject == GameResult.Draw) ? 1 : 0;

                table.AddRow(item.Round, item.PlayerOneObject, item.PlayerTwoObject, item.WinnerObject, item.WinnerPlayer);
            }
            
            table.Write(Format.Alternative);
            Console.WriteLine(string.Format("PlayerOne Total = {0}\nPlayerTwo Total = {1}\nRockieMistakes(draw)= {2}", PlayerOnePoints, PlayerTwoPoints, RockieMistakes));
        }
    }
}
