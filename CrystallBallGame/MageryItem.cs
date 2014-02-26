using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    class MageryItem : Items
    {
        //private const Dictionary<string, int> pointValues = new Dictionary<string, int> { { "Magic talisman", 1 } };
        public MageryItem(string name, int pointValue, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
          //  this.pointValue = pointValues[name];
        }

        public int PointValue { get { return this.pointValue; } }
    }
}
