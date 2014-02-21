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
            StringBuilder map = Map.DrawMap();

            Console.WriteLine(map.ToString());

        }
    }
}
