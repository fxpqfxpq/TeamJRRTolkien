namespace CrystallBallGame
{
    using System;
    class DrawEngine
    {
        //Draw a single character at the given console coordinates
        public static void DrawCharOnPosition(int posX, int posY, char c, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(c);
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
