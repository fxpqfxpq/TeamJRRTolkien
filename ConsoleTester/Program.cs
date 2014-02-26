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
        public static int playerX = 2;
        public static int playerY = 5;
        public static char playerSymbol = (char)2;
        const int MaxWidth = 90;
        const int MinWidth = 0;
        const int MaxHeight = 30;
        const int MinHeight = 30;

        static void Main(string[] args)
        {
            Console.CursorVisible = false; //hide cursor in console

            // Set console dimensions
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 90;
            Console.CursorVisible = false;

            Hero playerOne = new Hero("Billbooo", CreatureType.Hobbit);

            Map map = new Map();
            char[,] currMap = map.MapLevel;
            DrawMap(currMap, 8, 2);
            DrawPlayer();


            Console.WriteLine();

            while (true)
            {
                DrawMap(currMap, 8, 2);
                DrawPlayer();

                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    Move();
                }
                Console.CursorVisible = false;
            }
            Console.WriteLine();

        }

        //testing map drawing
        private static void DrawMap(char[,] chArr, int startX, int startY)
        {
            ConsoleColor currColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(startX, startY);

            for (int row = 0; row < chArr.GetLength(0); row++)
            {
                for (int col = 0; col < chArr.GetLength(1); col++)
                {
                    if (chArr[row, col] == '~')
                        currColor = ConsoleColor.Cyan;

                    if (chArr[row, col] == '-' || chArr[row, col] == '(' || chArr[row, col] == ')')
                        currColor = ConsoleColor.Yellow;

                    char currSymbol = chArr[row, col];

                    if (startX + col == playerX && startY + row == playerY)
                    {
                        currSymbol = playerSymbol;
                    }

                    Console.SetCursorPosition(startX + col, startY + row);
                    Console.ForegroundColor = currColor;
                    Console.Write(currSymbol);
                    currColor = ConsoleColor.DarkGreen; //reset default color
                }
            }
        }

        //testing player moving
        public static void Move()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (playerX - 1 >= MinWidth)
                    {
                        playerX--;
                    }
                }

                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (playerX + 1 < MaxWidth)
                    {
                        playerX++;
                    }
                }

                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (playerY - 1 >= MinWidth)
                    {
                        playerY--;
                    }
                }

                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (playerY + 1 < MaxHeight)
                    {
                        playerY++;
                    }
                }
            }
        }

        //testing player drawing
        private static void DrawPlayer()
        {
            List<int> playerCoordinates = new List<int>() 
            { 
                playerX,
                playerY 
                
            };

            ConsoleColor playerColor = ConsoleColor.Magenta;
            DrawEngine.DrawSymbolAtCoordinates(playerCoordinates, playerSymbol, playerColor);
        }
    }
}
