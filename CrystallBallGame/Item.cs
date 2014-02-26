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
        protected Creature itemOwner;

        public Items(string name, int requiredLevel, int stackable)
        {
            this.name = name;
            this.requiredLevel = requiredLevel;
            this.stackable = stackable;
        }

        public int PointValue { get { return this.pointValue; } }

        public int RequiredLevel { get { return this.requiredLevel; } }

        public int Stackable { get { return this.stackable; } }

        public Creature ItemOwner 
        { 
            get { return this.itemOwner; }
            set { this.itemOwner = value; }
        }

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
                    throw new ImproperlyDefinedItemException("Name must be at least 3 symbols and could contain only latin letters");
                }

                this.name = value;
            }
        }
    }
}
