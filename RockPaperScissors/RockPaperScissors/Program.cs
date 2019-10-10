using RockPaperScissors.Abstract;
using RockPaperScissors.Concrete;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game(); //it is always recommended to create dependency on abstraction (Dependency inversion principle)

            game.Play();
            game.ShowResults();

            Console.ReadLine();
        }
    }
}
