using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;

namespace PacMan.Monsters
{
    class Clyde : Monster
    {
        internal Clyde(Dot runawayDot, Dot currentDot)
            : base(runawayDot, currentDot)
        {
            
        }

        internal Clyde(Dot runawayDot, Dot currentDot, Dot targetDot)
            : base(runawayDot, currentDot, targetDot)
        {
 
        }
    }
}
