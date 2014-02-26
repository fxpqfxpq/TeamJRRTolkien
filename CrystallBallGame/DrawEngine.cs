namespace CrystallBallGame
{
    using System;
    using System.Collections.Generic;
    public class DrawEngine
    {
        //Draw a single character at the given console coordinates
        public static void DrawSymbolAtCoordinates(List<int> coordinates, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(coordinates[0], coordinates[1]);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        //Draw a string at the given console coordinates
        public static void DrawStringOnPosition(int posX, int posY, string str, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        //Draw rectangle box with Edge-edge (char) and Fill-fill (char)
        public static void DrawABoxOnPosition(int posX, int posY, int width, int height, char Edge, char Fill)
        {

            Console.SetCursorPosition(posX, posY);
            for (int hd = 0; hd <= height; hd++)
            {

                for (int wd = 0; wd <= width; wd++)
                {

                    if (hd % height == 0 || wd % width == 0)
                    {
                        Console.SetCursorPosition(posX + wd, posY + hd);
                        Console.Write(Edge);
                    }

                    if (wd < width)
                        Console.Write(Fill);
                }

            }
        }
    }
}
