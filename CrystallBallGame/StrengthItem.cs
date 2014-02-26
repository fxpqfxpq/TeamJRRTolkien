using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class StrengthItem : Items
    {
        //private const Dictionary<string, int> pointValues = new Dictionary<string, int> { { "Platemail", 1 }, { "Magical armor", 2 }, { "Chainmail", 3 }, { "Bronze shield", 1 }, { "Iron shield", 2 }, { "Magical shield", 3 }, {"Guarding talisman", 1}, {"Strength talisman", 2} };

        public StrengthItem (string name, int pointValue, int requiredLevel, int stackable)
            : base(name, pointValue, requiredLevel, stackable)
        {
            //this.pointValue = pointValues[name];
        }

        //public int PointValue { get { return this.pointValue; } }
    }
}