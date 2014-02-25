using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystallBallGame
{
    public class DamageItem : Items
    {
        private const Dictionary<string, int> pointValues = new Dictionary<string, int> { { "Long sword", 1 }, { "Double bladed sword", 2 }, { "One handed sword", 3 }, { "Axe", 4 }, { "Magical sword", 5 } };

        public DamageItem(string name)
            : base(name)
        {
            this.pointValue = pointValues[name];
        }

        public int PointValue { get { return this.pointValue; } }
    }
}
