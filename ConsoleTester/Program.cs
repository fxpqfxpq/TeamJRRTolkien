using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystallBallGame;
using CrystallBallGame.UI;
using System.Threading;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; //hide cursor in console

            // Set console dimensions
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 90;

            Hero playerOne = new Hero("Billbooo", CreatureType.Hobbit);
            
            //Map gameMap = new Map();
            //string ns = gameMap.GameMap.ToString();
            //for (int i = 0; i < ns.Length; i++)
            //{
            //    if (ns[i] == '~')                
            //        Console.ForegroundColor = ConsoleColor.Cyan;

            //    if (ns[i] == '*')
            //        Console.ForegroundColor = ConsoleColor.Red;

            //    if (ns[i] == '-' || ns[i] == '(' || ns[i] == ')')
            //        Console.ForegroundColor = ConsoleColor.Yellow;

            //    Console.Write(ns[i]);

            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
            //}



            //playerOne.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }
                    playerOne.Move(pressedKey);

                    
                }
                DrawEngine.DrawCharOnPosition(playerOne.currColX, playerOne.currRowY, '*', ConsoleColor.Red);
                
                Thread.Sleep(50);
            }

        }
    }
}
