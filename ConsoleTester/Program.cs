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

            Hero playerOne = new Hero("Billbooo", CreatureType.Hobbit, playerX, playerY, heroMinX, heroMaxX, heroMinY, heroMaxY);

            //DrawMap(currMap, MapX, MapY);

            

            Map.DrawMap(MapX, MapY);
            playerOne.Draw();

            Console.ReadKey();

            while (true)
            {

                
                //playerX = playerOne.X;
                //playerY = playerOne.Y;

                //DrawMap(currMap, 8, 2);
               
                if (Console.KeyAvailable)
                {
                    Console.Clear();
                    playerOne.Move();
                }
                Map.DrawMap(MapX, MapY);
                playerOne.Draw();
                Console.CursorVisible = false;
            }
            

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
