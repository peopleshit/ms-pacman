﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal static class Constants
    {
        internal enum State { Monster, PacMan, Food, Empty, Bonus, Energizer, Wall };
        internal enum Road { None, Straight, Turn, SpecialTurn, ExitTurn };
        internal enum Direction { None, Up, Down, Left, Right };
        internal enum Status { Active, Inactive, Dead }
        internal enum Behavior { Chase, Scatter, Frightened };
        internal const int gridX = 36;
        internal const int gridY = 28;
        internal const int borderX = 10;
        internal const int borderY = 10;
    }
}
