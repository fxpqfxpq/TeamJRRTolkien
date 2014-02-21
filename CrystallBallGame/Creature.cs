namespace CrystallBallGame
{
    using System;
    using System.Text.RegularExpressions;
    public class Creature
    {
        protected const int MaximalExperience = 3000; 
        protected const int InitialExperience = 50;

        private  string name;
        private int currentExperience;
        private CreatureType creatureType;

        public Creature(string name, CreatureType creatureType)
        {
            this.Name = name;
            this.CreatureType = creatureType;

            CurrentExperience = InitialExperience;
            
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (!Regex.IsMatch(value, @"\b[A-Za-z][A-Za-z][A-Za-z]+\b"))
                {
                    throw new ImproperlyDefinedCreatureException(string.Format("{0} name must be at least 3 symbols and could contain only latin letters", value));
                }

                this.name = value;
            }
        }
        public CreatureType CreatureType
        {
            get
            {
                return this.creatureType;
            }
            private set
            {
                if (Enum.IsDefined(typeof(CreatureType), value))
                {
                    this.creatureType = value;
                }
                else
                {
                    throw new ImproperlyDefinedCreatureException(string.Format("{0} this is not valid Creature to wallk on our world",value));
                }

            }
        }
        public int CurrentExperience
        {
            get
            {
                return this.currentExperience;
            }

            set
            {

                this.currentExperience = value;
            }
        }

    }
}
