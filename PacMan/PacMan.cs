using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;

namespace PacMan
{
    internal class PacMan
    {
        Dot currentDot;
        Constants.Direction direction;

        internal Dot CurrentDot
        {
            get { return currentDot; }
        }
    }
}
