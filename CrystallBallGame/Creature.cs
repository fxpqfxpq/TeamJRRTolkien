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

        /* 
         * Petar Nikov [note]: Think that this need to be moved inside Hero and Enemy classes
         * so in time of creation of Hero or Enemy to set their shape and/or position
        */

        //creature shape "*", positon of creature initialization
        private const char cratureShape = '*';
        private static int startPosRow = 11;
        private static int startPosCol = 58;

        
        public int CurrPosRow { get; private set; }
        public int CurrPosCol { get; private set; }


        public Creature(string name, CreatureType creatureType)
        {
            this.Name = name;
            this.CreatureType = creatureType;

            CurrentExperience = InitialExperience;
            
            this.CurrPosRow = startPosRow;
            this.CurrPosCol = startPosCol;
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


        //Moving the creature
        public void MoveLeft()
        {
            this.CurrPosCol--;
            if (this.CurrPosCol < 1)
            {
                this.CurrPosCol = 1;
            }
        }

        public void MoveRight()
        {
            this.CurrPosCol++;
            if (this.CurrPosCol> 67)
            {
                this.CurrPosCol = 67;
            }
        }

        public void MoveUp()
        {
            this.CurrPosRow--;
            if (this.CurrPosRow < 1)
            {
                this.CurrPosRow = 1;
            }
        }

        public void MoveDown()
        {
            this.CurrPosRow++;
            if (this.CurrPosRow > 20)
            {
                this.CurrPosRow = 20;
            }
        }

        public void Draw()
        {
            DrawEngine.DrawCharOnPosition(this.CurrPosCol, this.CurrPosRow, cratureShape, ConsoleColor.Red);
        }
    }
}
