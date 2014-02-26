
namespace CrystallBallGame.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Menu
    {
        private List<Logo> logos;
        public Menu()
        {

            this.logos = new List<Logo>();
            this.logos.Add(new StartLogo());
            this.logos.Add(new GuideLogo());
            this.logos.Add(new ScoreLogo());
            this.logos.Add(new ExitLogo());
            //this.logos.Add(new GoodByeLogo());
        }
        public void ShowMenu()
        {
            int choise = 0;
            PrintMenu(choise);

            ConsoleKeyInfo inputKey;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    inputKey = Console.ReadKey();
                    if (inputKey.Key == ConsoleKey.LeftArrow)
                    {
                        choise--;
                        choise += 4;
                        choise %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.RightArrow)
                    {
                        choise++;
                        choise %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.Enter)
                    {
                        string myChoise = MakeChoose(choise);
                        if (myChoise == "Start")
                        {
                            break;
                        }
                        else if (myChoise == "ReadGuide")
                        {
                            ReadGuide();
                        }
                        else if (myChoise == "ReadScores")
                        {
                            ReadScores();
                        }
                        else
                        {
                            //logos.Last().Print();
                            Environment.Exit(1);
                        }
                    }
                    Console.Clear();
                    PrintMenu(choise);
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
        }

        public void ReadScores()
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

                Console.WriteLine("NO HIGH SCORES ?");
            }
            ReturnToMainMenu();
        }

        public void ReadGuide()
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
                Console.WriteLine("File does not exist, ask from developer team");
                ReturnToMainMenu();
            }
        }

        public void ReturnToMainMenu()
        {
            Console.SetCursorPosition(26, 29);
            Console.WriteLine("Press [backspace] to return");
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
