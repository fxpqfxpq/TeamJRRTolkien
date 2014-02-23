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
            string ns = gameMap.GameMap.ToString();
            for (int i = 0; i < ns.Length; i++)
            {
                if (ns[i] == '~')                
                    Console.ForegroundColor = ConsoleColor.Cyan;

                if (ns[i] == '*')
                    Console.ForegroundColor = ConsoleColor.Red;

                if (ns[i] == '-' || ns[i] == '(' || ns[i] == ')')
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(ns[i]);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            playerOne.Draw();

        }
    }
}
