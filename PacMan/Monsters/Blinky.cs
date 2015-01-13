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
        internal Blinky(Dot runawayDot, Dot currentDot, PacMan pacman)
            : base(runawayDot, currentDot, pacman)
        {
            
        }

        internal Blinky(Dot runawayDot, Dot currentDot, Dot targetDot, PacMan pacman)
            : base(runawayDot, currentDot, targetDot, pacman)
        {
 
        }

        public override void Follow()
        {
            base.Follow();
            TargetDot = _pacman.CurrentDot;
        }
    }
}
