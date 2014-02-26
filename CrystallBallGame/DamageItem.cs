using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class DamageItem : Items
    {
        //private const Dictionary<string, int> pointValues = new Dictionary<string, int> { { "Long sword", 1 }, { "Double bladed sword", 2 }, { "One handed sword", 3 }, { "Axe", 4 }, { "Magical sword", 5 }, { "Bow", 1 }, { "Longbow", 2 }, {"Bloodrage talisman", 1}, {"Luck talisman", 2} };

        public DamageItem(string name, int pointValue, int requiredLevel, int stackable)
            : base(name, pointValue, requiredLevel, stackable)
        {
            //this.pointValue = pointValues[name];
        }

        //public int PointValue { get { return this.pointValue; } }
    }
}
