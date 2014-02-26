using System;

namespace CrystallBallGame
{
    public static class Randomizer
    {
        private static Random rnd = new Random();

        public static Random Rnd
        {
            get { return rnd; }
        }
    }
}
