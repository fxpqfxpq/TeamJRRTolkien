namespace CrystallBallGame
{
    using System;
    using System.Text.RegularExpressions;

    public abstract class Items
    {
        private string name;

        public Items(string name)
        {
            this.ItemType = this.GetType().Name;
            this.Name = name;
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
                    throw new ImproperlyDefinedItemException(string.Format("{0} name must be at least 3 symbols and could contain only latin letters", this.ItemType));
                }

                this.name = value;
            }
        }

        public string ItemType { get; private set; }
    }
}
