using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystallBallGame;
using CrystallBallGame.UI;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature playerOne = new Creature("Billbooo", CreatureType.Hobbit);
            Map gameMap = new Map();
            


            
            Console.WriteLine();
            Console.SetCursorPosition(1, 2);
            Console.Write(gameMap.ToString());

        }
    }
}
