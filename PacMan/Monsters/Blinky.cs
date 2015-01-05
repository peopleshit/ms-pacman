using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;

namespace PacMan.Monsters
{
    internal class Blinky : Monster
    {
        internal Blinky(Dot runawayDot, Dot currentDot)
            : base(runawayDot, currentDot)
        {
            
        }

        internal Blinky(Dot runawayDot, Dot currentDot, Dot targetDot)
            : base(runawayDot, currentDot, targetDot)
        {
 
        }
    }
}
