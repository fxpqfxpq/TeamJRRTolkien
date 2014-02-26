using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class ResistingSpellsItem : Items
    {
        //private const Dictionary<string, int> pointValues = new Dictionary<string, int> { { "Foresight talisman", 1 } };
        public ResistingSpellsItem(string name, int pointValue, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
            //this.pointValue = pointValues[name];
        }

        //public int PointValue { get { return this.pointValue; } }
    }
}
