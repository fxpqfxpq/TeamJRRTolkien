namespace CrystallBallGame
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class Items
    {
        protected string name;
        protected int pointValue; // how many points it adds to the Creature's attributes
        protected int requiredLevel; // required Hero level to use item
        protected int stackable; //if item is stackable: 0 = no, 1 can stack with 1 only, 2 with 2, etc.

        public Items(string name, int pointValue, int requiredLevel, int stackable)
        {
            this.Name = name;
            this.PointValue = pointValue;
            this.RequiredLevel = requiredLevel;
            this.Stackable = stackable;
        }

        public int PointValue { get; set; }

        public int RequiredLevel { get; set; }

        public int Stackable { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (!Regex.IsMatch(value, @"\b[A-Za-z][A-Za-z][A-Za-z]+\w\b"))
                {
                    throw new ImproperlyDefinedItemException(string.Format("{0} name must be at least 3 symbols and could contain only latin letters", this.ItemType));
                }

                this.name = value;
            }
        }
    }
}
