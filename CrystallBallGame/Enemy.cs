namespace CrystallBallGame
{
    public class Enemy : Creature, IDead, IDrawable
    {
        public Enemy(string name, CreatureType creatureType) : base(name, creatureType) { }

        public bool IsDead
        {
            get;
            set;
        }

        public void Draw()
        {
            //TODO
            throw new System.NotImplementedException();
        }


        public int HitPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
