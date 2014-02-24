namespace CrystallBallGame
{
    class Enemy : Creature, IDead, IDrawable
    {
        public Enemy(string name, CreatureType creatureType) : base(name, creatureType) { }

        public bool IsDead
        {
           get;
        }
    }
}
