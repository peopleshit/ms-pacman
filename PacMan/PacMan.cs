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
        Dot _currentDot;
        Constants.Direction direction;
        Grid.Grid _grid;

        internal Dot CurrentDot
        {
            get { return _currentDot; }
        }

        internal PacMan(Grid.Grid grid)
        {
            _grid = grid;
        }

        internal Dot SetTarget()
        {
            if (direction == Constants.Direction.Down)
                return _grid.GameGrid[_currentDot.DotUI.GridX + 1, _currentDot.DotUI.GridY];
            else if (direction == Constants.Direction.Up)
                return _grid.GameGrid[_currentDot.DotUI.GridX - 1, _currentDot.DotUI.GridY];
            else if (direction == Constants.Direction.Left)
                return _grid.GameGrid[_currentDot.DotUI.GridX, _currentDot.DotUI.GridY - 1];
            else if (direction == Constants.Direction.Right)
                return _grid.GameGrid[_currentDot.DotUI.GridX, _currentDot.DotUI.GridY + 1];
            else
                throw new ArgumentOutOfRangeException("I dunno where to go! :(");
        }
    }
}
