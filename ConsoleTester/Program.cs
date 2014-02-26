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
        //testing player
        public static int playerX = 9;
        public static int playerY = 3;
        public static char playerSymbol = (char)2;
        const int MaxWidth = 90;
        const int MinWidth = 0;
        const int MaxHeight = 30;
        const int MinHeight = 0;
        const int MapX = 8;
        const int MapY = 2;

        static void Main(string[] args)
        {
            Console.CursorVisible = false; //hide cursor in console

            // Set console dimensions
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 90;
            Console.CursorVisible = false;

            Map map = new Map();
            char[,] currMap = map.MapLevel;
            int heroMinX = MinWidth+MapX;
            int heroMaxX = MinWidth+ MapX + currMap.GetLength(1) - 2; //-2 two two empty chars at the end of line
            int heroMinY = MinHeight + MapY;
            int heroMaxY = MinHeight + MapY + currMap.GetLength(0);

            //Hero playerOne = new Hero("Billbooo", CreatureType.Hobbit, playerX, playerY, heroMinX, heroMaxX, heroMinY, heroMaxY);

            //Map.DrawMap(MapX, MapY);
            //playerOne.Draw();

            //Console.ReadKey();

            //while (true)
            //{               
            //    if (Console.KeyAvailable)
            //    {
            //        Console.Clear();
            //        playerOne.Move();
            //    }
            //    Map.DrawMap(MapX, MapY);
            //    playerOne.Draw();
            //    Console.CursorVisible = false;
            //}

            StartLogo st = new StartLogo();
            st.Print(5,10);
            
        }
    }
}
