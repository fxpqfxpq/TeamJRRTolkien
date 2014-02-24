namespace CrystallBallGame
{
    using System;
    class Hero : Creature, IDead, IMovable, IDrawable
    {
        public Hero(string name, CreatureType creatureType)
        :base(name, creatureType)
        {
        }

        public void Move()
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool IsDead
        {
            get { throw new NotImplementedException(); }
        }
    }
}
