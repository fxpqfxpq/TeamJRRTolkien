using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class ResistingSpellsItem : Items
    {
        public ResistingSpellsItem(string name, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
        }

        //public int PointValue { get { return this.pointValue; } }

        public override void GenerateDictionaries()
        {
            this.pointValues.Add("Foresight talisman", 1);
        }
    }
}
