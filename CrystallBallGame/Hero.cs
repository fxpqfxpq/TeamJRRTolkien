namespace CrystallBallGame
{
    using System;
    public class Hero : Creature, IDead, IMovable, IDrawable
    {
        public int currRowY { get; set; }
        public int currColX { get; set; }

        public Hero(string name, CreatureType creatureType)
        :base(name, creatureType)
        {
        }

        public Hero(string name, CreatureType creatureType, int x = 0, int y = 0)
        :this(name, creatureType)
        {
            this.currColX = x;
            this.currRowY = y;
        }

        public void Move(ConsoleKeyInfo pressedKey)
        {
            //TODO  - check for borders
            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                this.currRowY--;
                
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                this.currRowY++;
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                this.currColX--;
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                this.currColX++; 
            }
        }

        public bool IsDead
        {
            get { throw new NotImplementedException(); }
        }

        public void Draw()
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
