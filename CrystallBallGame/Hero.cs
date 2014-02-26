namespace CrystallBallGame
{
    using System;
    using System.Collections.Generic;
    public class Hero : Creature, IDead, IMovable, IDrawable
    {
        private const ConsoleColor heroColor = ConsoleColor.Magenta;
        private const char heroSymbol = (char)2;

        //properties for where it can go
        public int MinWidth { get;  set; }
        public int MaxWidth { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }

        public Hero(string name, CreatureType creatureType)
        :base(name, creatureType)
        { }

        public Hero(string name, CreatureType creatureType, int x = 0, int y = 0)
        :base(name, creatureType, x, y)
        { }

        public Hero(string name, CreatureType creatureType, int x, int y, int minX, int maxX, int minY, int maxY)
            :this(name, creatureType, x, y)
        {
            this.MinWidth = minX;
            this.MaxWidth = maxX;
            this.MinHeight = minY;
            this.MaxHeight = maxY;
        }

        public void Move()
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
                    if (this.X - 1 >= MinWidth)
                    {
                        this.X--;
                    }
                }

                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (this.X + 1 < MaxWidth)
                    {
                        this.X++;
                    }
                }

                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (this.Y - 1 >= MinHeight)
                    {
                        this.Y--;
                    }
                }

                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (this.Y + 1 < MaxHeight)
                    {
                        this.Y++;
                    }
                }
            }
        }

        public bool IsDead
        {
            get { throw new NotImplementedException(); }
        }

        public void Draw()
        {
            List<int> heroCoordinates = new List<int>() 
            { 
                this.X,
                this.Y    
            };

            DrawEngine.DrawSymbolAtCoordinates(heroCoordinates, heroSymbol, heroColor);
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Name;
        }


        public int HitPoints
        {
            get
            {
                //TODO
                throw new NotImplementedException();
            }
            set
            {
                //TODO
                throw new NotImplementedException();
            }
        }
    }
}
