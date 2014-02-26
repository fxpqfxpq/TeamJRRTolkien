using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class DamageItem : Items
    {
        public DamageItem(string name, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
        }

        //public int PointValue { get { return this.pointValue; } }

        public override void GenerateDictionaries()
        {
            this.pointValues.Add("Long sword", 1);
            this.pointValues.Add("Double bladed sword", 2);
            this.pointValues.Add("One handed sword", 3);
            this.pointValues.Add("Axe", 4);
            this.pointValues.Add("Magical sword", 5);
            this.pointValues.Add("Bow", 1);
            this.pointValues.Add("Longbow", 2);
            this.pointValues.Add("Bloodrage talisman", 1);
            this.pointValues.Add("Luck talisman", 2);
        }
    }
}
