using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame
{
    public interface IControllable : IDead
    {
        string Name
        {
            get;
        }
    }
}
