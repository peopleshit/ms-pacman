using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    internal class Game
    {
        Grid.Grid _grid;

        internal Grid.Grid Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        internal Game()
        {
            _grid = new Grid.Grid();
        }

        internal List<UI.DotUI> GenerateInitialGrid()
        {
            List<UI.DotUI> UI = new List<UI.DotUI>();
            for (int i = 0; i < Constants.gridX; i++)
                for (int j = 0; j < Constants.gridY; j++)
                {
                    UI.Add(_grid.GameGrid[i, j].DotUI);
                }
            return UI;
        }
    }
}
