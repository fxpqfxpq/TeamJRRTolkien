using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame
{
    public abstract class WorldObject : IDead
    {
        public int HitPoits { get; set; }

        public int Owner { get; set; }

        public Point Position { get; protected set; }

        public bool IsDestroyed
        {
            get
            {
                return this.HitPoits <= 0;
            }
        }

        public WorldObject(Point position, int owner)
        {
            this.Owner = owner;
            this.Position = position;
            this.HitPoits = 0;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public bool IsDead
        {
            get { throw new NotImplementedException(); }
        }

        public int HitPoints
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
