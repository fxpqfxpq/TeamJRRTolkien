using System;
using System.Collections.Generic;
using System.Linq;

namespace CrystallBallGame
{
    class MageryItem : Items
    {
        private readonly Dictionary<string, int> pointValues = new Dictionary<string, int>();

        public MageryItem(string name, int pointValue, int requiredLevel, int stackable)
            : base(name, requiredLevel, stackable)
        {
           this.GenerateDictionaries();
           this.pointValue = pointValues[name];
        }

        public override void GenerateDictionaries()
        {
            this.pointValues.Add("Magic talisman", 1);
        }
    }
}
