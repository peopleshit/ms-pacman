using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal static class Constants
    {
        internal enum State { Monster, PacMan, Food, Empty, Bonus, Energizer, Wall };
        internal enum Road { Straight, Turn, SpecialTurn };
        internal const int gridX = 36;
        internal const int gridY = 28;
    }
}
