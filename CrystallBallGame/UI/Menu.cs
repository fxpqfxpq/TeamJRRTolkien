namespace CrystallBallGame.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Menu
    {
        private const int MenuItemHeight = 3;
        private List<Logo> logos;
        public Menu()
        {

            this.logos = new List<Logo>();
            this.logos.Add(new StartLogo());
            this.logos.Add(new GuideLogo());
            this.logos.Add(new ScoreLogo());
            this.logos.Add(new ExitLogo());
            this.logos.Add(new GoodByeLogo());
        }
        public void ShowMenu()
        {
            int choice = 0;
            PrintMenu(choice);

            ConsoleKeyInfo inputKey;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    inputKey = Console.ReadKey();
                    if (inputKey.Key == ConsoleKey.LeftArrow)
                    {
                        choice--;
                        choice += 4;
                        choice %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.RightArrow)
                    {
                        choice++;
                        choice %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.Enter)
                    {
                        string myChoise = MakeChoose(choice);
                        if (myChoise == "Start")
                        {
                            break;
                        }
                        else if (myChoise == "ReadGuide")
                        {
                            GetHelp();
                        }
                        else if (myChoise == "ReadScores")
                        {
                            GetScores();
                        }
                        else
                        {
                            logos.Last().Print(0, 0);
                            Environment.Exit(1);
                        }
                    }
                    Console.Clear();
                    PrintMenu(choice);
                }
            }
        }

        private string MakeChoose(int choice)
        {
            Console.Clear();
            string result = string.Empty;

            switch (choice)
            {
                case 0:
                    result = "Start";
                    break;
                case 1:
                    result = "ReadGuide";
                    break;
                case 2:
                    result = "ReadScores";
                    break;
                case 3:
                    result = "GoodBye";
                    break;
            }

            return result;
        }

        public void PrintMenu(int choose)
        {
            int sRow = (Console.BufferHeight / 2) - MenuItemHeight;
            int sCol = 20;

            switch (choose)
            {
                case 0:
                    logos[0].Selected = true;
                    break;
                case 1:
                    logos[1].Selected = true;
                    break;
                case 2:
                    logos[2].Selected = true;
                    break;
                case 3:
                    logos[3].Selected = true;
                    break;
            }

            for (int index = 0; index < this.logos.Count - 1 ; index++)
            {
                if (this.logos[index].Selected)
                {
                    this.logos[index].Print(sCol, sRow);
                    this.logos[index].Selected = false;
                }
                else
                {
                    this.logos[index].Print(sCol, sRow);
                }
                sCol += 12;
            }
        }

        public void GetScores()
        {
            int positionX = 10;
            int positionY = 20;

            if (File.Exists(@"score.txt"))
            {
                StreamReader reader = new StreamReader(@"score.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    int count = 1;
                    while (line != null && count < 6)
                    {
                        var currLine = line.Split('-');
                        Console.SetCursorPosition(positionY, ++positionX);
                        Console.WriteLine(count++ + ". " + currLine[0] + " " + currLine[1]);
                        line = reader.ReadLine();
                        positionX++;
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(32, 15);

                Console.WriteLine("NO HIGH SCORES?");
            }
            ReturnToMainMenu();
        }

        public void GetHelp()
        {
            Console.SetCursorPosition(0, 0);

            if (File.Exists(@"helpers.txt"))
            {
                Console.Clear();
                StreamReader reader = new StreamReader(@"helpers.txt");

                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.SetCursorPosition(23, 5 + lineNumber);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                ReturnToMainMenu();
            }
            else
            {
                Console.SetCursorPosition(19, 15);
                Console.WriteLine("Someone lost this file!");
                ReturnToMainMenu();
            }
        }

        public void ReturnToMainMenu()
        {
            string msg = "Press [backspace] to return";
            Console.SetCursorPosition(Console.BufferWidth - (msg.Length / 2), Console.BufferHeight - 5);
            Console.WriteLine(msg);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
        }
    }
}
