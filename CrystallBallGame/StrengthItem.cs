using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    public class StrengthItem : Items
    {
        public StrengthItem (string name, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
        }

        //public int PointValue { get { return this.pointValue; } }

        public override void GenerateDictionaries()
        {
            this.pointValues.Add("Platemail", 1);
            this.pointValues.Add("Magical armor", 2);
            this.pointValues.Add("Chainmail", 3);
            this.pointValues.Add("Bronze shield", 1);
            this.pointValues.Add("Iron shield", 2);
            this.pointValues.Add("Magical shield", 3);
            this.pointValues.Add("Guarding talisman", 1);
            this.pointValues.Add("Strength talisman", 2);
        }
    }
}